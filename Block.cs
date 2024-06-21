using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace instagov_prototype
{
    public class HexadecimalEncoding
    {
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba) { hex.AppendFormat("{0:x2}", b);  }
            return hex.ToString();
        }
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2) { bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16); }
            return bytes;
        }
    }

    public class Block
    {
        public uint this_block_height { get; set; }
        public uint the_miningnodeversion { get; set; }
        public string this_block_merkloroot { get; set; }
        public byte[] prev_block_hash { get; set; }
        public byte[] this_block_hash { get; set; }
        public uint this_block_timestamp { get; set; }
        public uint number_of_tx_in_block { get; set; }
        public uint this_block_difficulty { get; set; }
        public uint nonce { get; set; }


        public string GenHash(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            return HexadecimalEncoding.ByteArrayToString(bytes);
        }

        public static string DoubleHash(string leaf1, string leaf2)
        {
            byte[] leaf1Byte = HexadecimalEncoding.StringToByteArray(leaf1);
            byte[] leaf2Byte = HexadecimalEncoding.StringToByteArray(leaf2);
            var concatHash = leaf1Byte.Concat(leaf2Byte).ToArray();
            SHA256 sha256 = SHA256.Create();
            byte[] sendHash = sha256.ComputeHash(sha256.ComputeHash(concatHash));
            return HexadecimalEncoding.ByteArrayToString(sendHash).ToLower();
        }

        public static string CreateMerkleRoot(string[] txsHash)
        {
            while (true)
            {
                if (txsHash.Length == 0)
                {
                    return string.Empty;
                }
                if (txsHash.Length == 1)
                {
                    return txsHash[0];
                }
                List<string> newHashList = new List<string>();
                int len = (txsHash.Length % 2 != 0) ? txsHash.Length - 1 : txsHash.Length;
                for (int i = 0; i < len; i += 2)
                {
                    newHashList.Add(DoubleHash(txsHash[i], txsHash[i + 1]));
                }
                if (len < txsHash.Length)
                {
                    newHashList.Add(DoubleHash(txsHash[1], txsHash[1]));
                }
                txsHash = newHashList.ToArray();
            }
        }
    }
}
