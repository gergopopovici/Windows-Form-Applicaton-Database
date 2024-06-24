using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace adatbazis
{
    internal class SaltHash
    {
        public static byte[] GenerateSalt(int length)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[length];
                rng.GetBytes(salt);
                return salt;
            }
        }
        public static byte[] Hashpassword(string password, byte[] salt)
        {
            using (SHA512 HashAlgorithm = SHA512.Create())
            {
                byte[] saltedPassword = Encoding.UTF8.GetBytes(password).Concat(salt).ToArray();
                return HashAlgorithm.ComputeHash(saltedPassword);
            }
        }
       public static string ByteArrayToBase64String(byte[] data)
        {
            return Convert.ToBase64String(data);
        }
        public static string ByteArrayToHexString(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", "");
        }
    }
}
