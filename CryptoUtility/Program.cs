using System;

// ReSharper disable StringLiteralTypo

namespace Crypto
{
    internal static class Program
    {
        private static void Main()
        {

            var key = new Block(66);
            var iv = new Block(70);
            const string x = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean commodo augue eget diam laoreet suscipit. Praesent eu mi in elit dictum pretium. Pellentesque iaculis semper mauris, ut congue pharetra.";
            
            var alg = new SecurityAlgorithm(key, iv, BlockCipherMode.ECB);
            var list = x.SplitInBlocks();
            
            var enc = alg.EncryptList(list);
            var dec = alg.DecryptList(enc);
            
            Console.WriteLine(dec.MergeToString());
        }
    }
}