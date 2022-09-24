using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Infrastructure
{
    public class PasswordEncryptor
    {
        public static string Encyrpt(string password)
        {
            using var md5 = MD5.Create();

            byte[] inputTypes = Encoding.ASCII.GetBytes(password);
            byte[] hashBytes = md5.ComputeHash(inputTypes);

            return Convert.ToHexString(hashBytes);
        }
    }
}
