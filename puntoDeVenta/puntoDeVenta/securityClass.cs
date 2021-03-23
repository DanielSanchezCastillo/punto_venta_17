using System;
using System.Collections.Generic;
using System.Text;

namespace puntoDeVenta
{
    class securityClass
    {
        public string encryptUser(string user)
        {
            string responseUser = string.Empty;
            byte[] encrypedUser = System.Text.Encoding.Unicode.GetBytes(user);
            responseUser = Convert.ToBase64String(encrypedUser);
            return responseUser;
        }

        public static string encryptPassword(string password)
        {
            string responsePass = string.Empty;
            byte[] encrypedPassword = System.Text.Encoding.Unicode.GetBytes(password);
            responsePass = Convert.ToBase64String(encrypedPassword);
            return responsePass;
        }

        public static string decryptUser(string userEncrypt)
        {
            string responseUserDecrypt = string.Empty;
            byte[] decryted = Convert.FromBase64String(userEncrypt);
            responseUserDecrypt = System.Text.Encoding.Unicode.GetString(decryted);
            return responseUserDecrypt;
        }

        public static string decryptPass(string passEncrypt)
        {
            string responsePassDecrypt = string.Empty;
            byte[] decryted = Convert.FromBase64String(passEncrypt);
            responsePassDecrypt = System.Text.Encoding.Unicode.GetString(decryted);
            return responsePassDecrypt;
        }
    }
}
