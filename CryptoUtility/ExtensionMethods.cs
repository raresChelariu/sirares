using System;
using System.Collections.Generic;
using System.Linq;

namespace Crypto
{
    public static class ExtensionMethods
    {
        public static List<Block> SplitInBlocks(this string s)
        {
            var result = new List<Block>();
            var finalBlockLength = s.Length % Block.BlockLength;
            var length = s.Length - finalBlockLength;
            string subStr;
            for (var i = 0; i < length; i += Block.BlockLength)
            {
                subStr = s.Substring(i, Block.BlockLength);
                result.Add(new Block(subStr));
            }
            if (finalBlockLength == 0)
                return result;
            
            subStr = s.Substring(length, finalBlockLength);
            result.Add(new Block(subStr));
            return result;
        }

        public static string MergeToString(this List<Block> list)
        {
            return list.Aggregate("", (current, block) => current + block);
        }
        public static Block Xor(this Block x, Block y)
        {
            var result = new byte[Block.BlockLength];
            for (var i = 0; i < Block.BlockLength; i++)
            {
                result[i] = (byte) (x.GetB()[i] ^ y.GetB()[i]);
            }
            return new Block(result);
        }
      
    }
}