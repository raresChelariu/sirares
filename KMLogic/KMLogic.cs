using System;
using System.Net;
using System.Net.Sockets;
using Crypto;


namespace KMLogic
{
    public static class KmLogic
    {
        private const int Port = 5000;
        private static Socket _socketA, _socketB;
        private static SecurityAlgorithm _algorithm;

        public static void ListeningForConnections()
        {
            var ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            var ipAddress = ipHostInfo.AddressList[0];
            var localEndPoint = new IPEndPoint(ipAddress, Port);

            var listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            listener.Bind(localEndPoint);
            listener.Listen(10);

            Console.WriteLine("Ready to accept new connection...");
            _socketA = listener.Accept();
            Console.WriteLine("First client accepted!");
            _socketB = listener.Accept();
            Console.WriteLine("Both clients accepted!");
            SettingSecrets();
        }

        private static void SettingSecrets()
        {
            var encryptionMode = SetCryptoAlgorithm();
            return;
            SendKeysToNodes(encryptionMode);

            var inputList = "heyy looka this 1234g5g5asd789a9sd3".SplitInBlocks();
            var encryptedList = _algorithm.EncryptList(inputList);
            var decryptedlist = _algorithm.DecryptList(encryptedList);



            Console.WriteLine(inputList.ToString());
            Console.WriteLine(encryptedList.ToString());
            Console.WriteLine(decryptedlist.ToString());
        }

        private static void SendKeysToNodes(BlockCipherMode mode)
        {
            switch (mode)
            {
                case BlockCipherMode.ECB:
                    _socketA.WriteBytes(Secrets.KeyEcb.Encrypt(Secrets.Key3).GetB());
                    break;
                case BlockCipherMode.CFB:
                    _socketB.WriteBytes(Secrets.KeyCfb.Encrypt(Secrets.Key3).GetB());
                    _socketB.WriteBytes(Secrets.Iv.Encrypt(Secrets.Key3).GetB());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

        private static BlockCipherMode SetCryptoAlgorithm()
        {

            var preferenceA = _socketA.ReadString();
            var preferenceB = _socketB.ReadString();
            Console.WriteLine("Preferences read from clients.");
            var finalChoice = "ECB";
            var randomChoice = new Random().Next(0, 1) == 0 ? "ECB" : "CFB";
            BlockCipherMode mode;
            if (preferenceA.Equals("CFB") && preferenceB.Equals("CFB"))
            {
                _algorithm = new SecurityAlgorithm(Secrets.KeyCfb, Secrets.Iv, BlockCipherMode.CFB);
                mode = BlockCipherMode.ECB;
            }
            else if (preferenceA.Equals("ECB") && preferenceB.Equals("ECB") || randomChoice.Equals("ECB"))
            {
                _algorithm = new SecurityAlgorithm(Secrets.KeyEcb, Secrets.Iv, BlockCipherMode.ECB);
                mode = BlockCipherMode.ECB;
            }
            else
            {
                _algorithm = new SecurityAlgorithm(Secrets.KeyCfb, Secrets.Iv, BlockCipherMode.CFB);
                finalChoice = "CFB";
                mode = BlockCipherMode.CFB;
            }

            _socketA.WriteString(finalChoice);
            _socketB.WriteString(finalChoice);
            Console.WriteLine("Final choice sent!");
            return mode;
        }
        
        
        

    }
}