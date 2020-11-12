using System;
using Crypto;

namespace KMLogic
{
    public static class Secrets
    {
        public static readonly Block KeyEcb = new Block(Convert.ToByte('{'));
        public static readonly Block KeyCfb = new Block(Convert.ToByte('~'));
        public static readonly Block Key3 = new Block(Convert.ToByte('|'));
        public static readonly Block Iv = new Block(Convert.ToByte('^'));
        public static readonly SecurityAlgorithm InitAlgorithm = new SecurityAlgorithm(Key3, null, BlockCipherMode.ECB); 
    }
}