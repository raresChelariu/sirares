using System;
using System.Collections.Generic;
using System.Linq;

namespace Crypto
{
    public class SecurityAlgorithm
    {
        private readonly Block _key;
        private Block _iv;
        private readonly BlockCipherMode _mode;
        private const int BlockLength = Block.BlockLength;

        public SecurityAlgorithm(Block key, Block iv, BlockCipherMode mode)
        {
            _key = key ?? throw new ArgumentNullException(nameof(key));
            _iv = iv != null || mode != BlockCipherMode.CFB ? iv : throw new ArgumentNullException(nameof(iv));
            _mode = mode;
        }
        public List<Block> EncryptList(List<Block> given)
        {
            return _mode switch
            {
                BlockCipherMode.ECB => EncryptEcb(given),
                BlockCipherMode.CFB => EncryptCfb(given),
                _ => throw new ArgumentException($"Unknown mode : {_mode}")
            };
        }
        public List<Block> DecryptList(List<Block> given)
        {
            return _mode switch
            {
                BlockCipherMode.ECB => DecryptEcb(given),
                BlockCipherMode.CFB => DecryptCfb(given),
                _ => throw new ArgumentOutOfRangeException($"Unknown mode : {_mode}")
            };
        }
        private List<Block> EncryptCfb(List<Block> given)
        {
            var result = new List<Block>();
            var lastCrypted = _iv;
            for (var i = 0; i < given.Count; i++)
            {
                result.Add(lastCrypted.Encrypt(_key).Xor(given[i]));
            }
            return result;
        }

        private List<Block> EncryptEcb(List<Block> given)
        {
            return given.Select(t => t.Encrypt(_key)).ToList();
        }
        private List<Block> DecryptEcb(List<Block> given)
        {
            return given.Select(element => element.Decrypt(_key)).ToList();
        }
        private List<Block> DecryptCfb(List<Block> given)
        {
            var result = new List<Block>();
            var lastCrypted = _iv;
            for (var i = 0; i < given.Count; i++)
            {
                result.Add(lastCrypted.Encrypt(_key).Xor(given[i]));
            }
            return result;
        }
    }
}