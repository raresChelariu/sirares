using System;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;

namespace Crypto
{
    public class Block
    {
        public const int BlockLength = 16;
        public const byte DefaultPaddingByte = 93;
        
        private readonly byte[] _b = new byte[BlockLength];

        public Block(string s)
        {
            if (s.Length > BlockLength)
                throw new ArgumentException($"{nameof(s)} has length of {s.Length}");
            for (var i = 0; i < s.Length; i++)
                _b[i] = (byte) s[i];
            for (var i = s.Length; i < BlockLength; i++)
                _b[i] = DefaultPaddingByte;
        }
        public Block(byte[] arr)
        {
            if (arr.Length != BlockLength)
                throw new ArgumentException($"Size of {nameof(arr)} is {arr.Length}");
            for (var i = 0; i < arr.Length; i++)
            {
                _b[i] = arr[i];
            }
        }

        public Block(byte onlyValueInBlock)
        {
            for (var i = 0; i < BlockLength; i++)
                _b[i] = onlyValueInBlock;
        }

        public Block Encrypt(Block key)
        {
            var resultedBytes = new byte[BlockLength];
            var aesAlg = GetAesAlg(key._b);
            var helper = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            helper.TransformBlock(_b, 0, BlockLength, resultedBytes, 0);
            return new Block(resultedBytes);
        }

        
        public Block Decrypt(Block key)
        {
            var resultedBytes = new byte[BlockLength];
            var aesAlg = GetAesAlg(key._b);
            var helper = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            helper.TransformBlock(_b, 0, BlockLength, resultedBytes, 0);
            return new Block(resultedBytes);
        }

        public byte[] GetB()
        {
            return _b;
        }
        private static AesManaged GetAesAlg(byte[] key)
        { 
            return new AesManaged
            {
                Mode = CipherMode.ECB,
                BlockSize = 128,
                KeySize = 128,
                Padding = PaddingMode.None,
                Key = key
            };;
        }

        public override string ToString()
        {
            return _b.Aggregate("", (current, currentByte) => current + Convert.ToChar(currentByte));
        }
    }
}