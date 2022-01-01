using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal class Cipher64 : ICipher
    {
        public string decode(string str)
        {
           byte [] data = Convert.FromBase64String(str);
           string decrypted = ASCIIEncoding.ASCII.GetString(data);
           return decrypted;
        }

        public string encode(string str)
        {
            byte [] data = ASCIIEncoding.ASCII.GetBytes(str);
            string encrypted = Convert.ToBase64String(data);
            return encrypted;

        }
    }
}
