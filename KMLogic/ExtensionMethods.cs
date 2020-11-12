using System;
using System.Globalization;
using System.Net.Sockets;
using System.Text;

namespace KMLogic
{
    public static class ExtensionMethods
    {
        public static void WriteString(this Socket node, string message)
        {
            node.Send(Encoding.ASCII.GetBytes(message + "<EOF>"));
        }

        public static string ReadString(this Socket node)
        {
            var data = new byte[1024];
            var dataLength = node.Receive(data);
            var s = Encoding.ASCII.GetString(data, 0, dataLength);
            return s.Substring(0, s.IndexOf("<EOF>", StringComparison.Ordinal));
        }

        public static void WriteBytes(this Socket node, byte[] given)
        {
            node.Send(given);
        }

        public static byte[] ReadBytes(this Socket node)
        {
            var data = new byte[1024];
            node.Receive(data);
            return data;
        }
    }
}