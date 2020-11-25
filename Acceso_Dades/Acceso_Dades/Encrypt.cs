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

        public byte[] StringToBytes(string text)
        {
            string[] array = text.Split('-');
            byte[] bytes = new byte[text.Length];
            for (int i = 0; i < array.Length; i++) bytes[i] = Convert.ToByte(array[i], 16);
            return bytes;
        }

        public string BytesToString(byte[] bytes)
        {
            return BitConverter.ToString(bytes, 0, 8);
        }

        public byte[] Hash
        (string password, byte[] salt, int iterations = 30000, int hashByteSize = 32)
        {
            Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt);
            hashGenerator.IterationCount = iterations;
            return hashGenerator.GetBytes(hashByteSize);
        }

        public byte[] Sal(int saltByteSize = 8)
        {
            RNGCryptoServiceProvider saltGenerator = new RNGCryptoServiceProvider();
            byte[] sal = new byte[saltByteSize];
            saltGenerator.GetBytes(sal);
            return sal;
        }

        public bool VerificarPass
        (string password, byte[] passwordSal, byte[] passwordHash)
        {
            byte[] computedHash = Hash(password, passwordSal);
            return HashesIguales(computedHash, passwordHash);
        }

        public bool HashesIguales(byte[] hash1, byte[] hash2)
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
