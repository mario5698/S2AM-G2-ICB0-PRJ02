using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Dades
{
    public class Encrypt
    {
        int saltLength;

        public Encrypt()
        {
            saltLength = 5;
        }

        public string Sal()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();
            for (int i = 0; i < saltLength; i++) stringChars[i] = chars[random.Next(chars.Length)];
            return new String(stringChars);
        }

        private byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public string HashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString)) sb.Append(b.ToString("X3"));
            return sb.ToString();
        }
    }
}
