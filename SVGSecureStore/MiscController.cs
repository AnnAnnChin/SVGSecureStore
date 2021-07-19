using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace SVGSecureStore
{
    class MiscController
    {
        Random stringGen = new Random();
        Random charGen = new Random();
        Random numGen = new Random();
        StringBuilder sb1 = new StringBuilder();    //String "creater" for GetRandomString method.
        StringBuilder sb2 = new StringBuilder();    //String "creater" for GetRandomUserID method.
        SHA256Managed hashFunction = new SHA256Managed();

        public MiscController()
        {
            
        }
        
        public string GetRandomString() //Generate a random 8 character string.
        {
            sb1.Clear();
            string charPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"; //Take any one of the character in this string

            for (int i = 0; i < 8; i++ )
            {
                sb1.Append(charPool[(int)(stringGen.NextDouble() * charPool.Length)]);  
            }
            
            return sb1.ToString();
        }

        public string GetRandomUserID() //Generate random User ID with format Uxxxxxx<CHAR>.
        {
            sb2.Clear();
            string charPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //Take any one of the character in this string
            int num = numGen.Next(100000, 999999);  //Generate random integer from 100000 to 999999
            sb2.Append(charPool[(int)(charGen.NextDouble() * charPool.Length)]);

            return "U" + num + sb2.ToString();
        }

        public string hashPassword(string password) //Hash a given password using SHA-256 format.
        {
            return Convert.ToBase64String(hashFunction.ComputeHash(Encoding.UTF8.GetBytes(password)));
        }
    }
}
