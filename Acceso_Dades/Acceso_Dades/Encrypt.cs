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
        public Encrypt()
        {

        }

        public static string Xd(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash(inputString, Sal()))
                sb.Append(b.ToString("X3"));

            return sb.ToString();
        }

        public static byte[] Hash
        (string password, byte[] salt, int iterations = 30000, int hashByteSize = 32)
        {
            Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt);
            hashGenerator.IterationCount = iterations;
            return hashGenerator.GetBytes(hashByteSize);
        }

        public static byte[] Sal(int saltByteSize = 8)
        {
            RNGCryptoServiceProvider saltGenerator = new RNGCryptoServiceProvider();
            byte[] sal = new byte[saltByteSize];
            saltGenerator.GetBytes(sal);
            return sal;
        }

        public static bool VerificarPass
        (String password, byte[] passwordSal, byte[] passwordHash)

        {
            byte[] computedHash = Hash(password, passwordSal);
            return HashesIguales(computedHash, passwordHash);
        }

        private static bool HashesIguales(byte[] hash1, byte[] hash2)
        {
            int minHashLenght = hash1.Length <= hash2.Length ?
            hash1.Length : hash2.Length;

            var xor = hash1.Length ^ hash2.Length;
            for (int i = 0; i < minHashLenght; i++)
                xor |= hash1[i] ^ hash2[i];
            return 0 == xor;
        }
    }
}
