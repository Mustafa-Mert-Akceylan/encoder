using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class Cipher : ICipher
    {
        public string encode(string str)
        {

            string encrypted = "";
            char[] chars = str.ToCharArray();
            foreach (var chr in chars)
            {
                encrypted += (char)(chr + 1);
            }
      
            return encrypted;
    
        }
        public string decode(string str)
        {
            string decrypted= "";
            char[] chars = str.ToCharArray();
            foreach (var chr in chars)
            {
                decrypted += (char)(chr -1);
            }

            return decrypted; 
        }
    }
}
