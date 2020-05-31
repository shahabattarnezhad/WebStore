using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace WebStore.Core.Security
{
    public static class PasswordHelper
    {
        public static string EncodePasswordMD5(string pass)
        {
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(pass);
            encodedBytes = md5.ComputeHash(originalBytes);
            return BitConverter.ToString(encodedBytes);
        }
    }
}
