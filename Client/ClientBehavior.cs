using Crypto;
using KMLogic;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public class ClientBehavior
    {
        private const int Port = 5000;
        private const string Eof = "<EOF>";
        private readonly Block Key3 = Secrets.Key3;

        private Socket _sender;
        private readonly BlockCipherMode modeChoice;
        private readonly BlockCipherMode modeFinal;

        public readonly SecurityAlgorithm alg;
        public ClientBehavior(BlockCipherMode modeChoice) 
        {
            
            this.modeChoice = modeChoice;
            _sender = GetClientSocket();
            this.modeFinal = GetFinalMode();
            Debug("Final mode chosen");
            alg = getSecurityAlgorithm();
            return;
            var inputList = "heyy looka this 1234g5g5asd789a9sd3".SplitInBlocks();
            var encryptedList = alg.EncryptList(inputList);
            var decryptedlist = alg.DecryptList(encryptedList);
 
            Debug(inputList.ToString());
            Debug(encryptedList.ToString());
            Debug(decryptedlist.ToString());
        }

        private SecurityAlgorithm getSecurityAlgorithm()
        {
            var bytesEncrypted = new byte[1024];
            ReadBytes(bytesEncrypted);
            return null;
            var key = new Block(bytesEncrypted).Decrypt(Secrets.Key3);
            Debug(key.ToString());
            if (modeChoice == BlockCipherMode.ECB)
            {
                return new SecurityAlgorithm(key, null, modeChoice);
            }
            ReadBytes(bytesEncrypted);
            var iv = new Block(bytesEncrypted).Decrypt(Secrets.Key3);
            Debug(iv.ToString());
            return new SecurityAlgorithm(key, iv, modeChoice);
        }
        private void Debug(string msg)
        {
            var path = $@"{Directory.GetCurrentDirectory()}\debug.txt";
            StreamWriter sw;
            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                sw.WriteLine($"Client : {msg}");
                sw.Close();
                return;
            }
            sw = File.AppendText(path);
            sw.WriteLine($"Client : {msg}");
            sw.Close();
        }
        private BlockCipherMode GetFinalMode()
        {
            WriteString(modeChoice == BlockCipherMode.ECB ? "ECB" : "CFB");
            var modeString = ReadString();
            return modeString == "ECB" ? BlockCipherMode.ECB : BlockCipherMode.CFB;
        }

        private static Socket GetClientSocket()
        {
            var ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());  
            var ipAddress = ipHostInfo.AddressList[0];  
            var remoteEp = new IPEndPoint(ipAddress, Port);
            var soc =  new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp );
            soc.Connect(remoteEp);
            return soc;
        }

        #region WRITE/READ BYTES/STRING
        public void WriteBytes(byte[] given)
        {
            _sender.Send(given);
        }

        public void ReadBytes(byte[] given)
        {
            _sender.Receive(given);
        }

        public void WriteString(string given)
        {
            _sender.Send(Encoding.ASCII.GetBytes(given + Eof));
        }

        public string ReadString()
        {
            var data = new byte[1024];
            var dataLength = _sender.Receive(data);
            var str = Encoding.ASCII.GetString(data, 0, dataLength);
            return str.Substring(0, str.IndexOf(Eof, StringComparison.Ordinal));
        }
        #endregion

    }
}