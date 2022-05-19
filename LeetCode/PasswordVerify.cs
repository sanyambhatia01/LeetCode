using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVerifier
{
    public class PasswordVerify
    {
        static bool VerifyPassword(string input)
        {
            bool num = false;
            bool upp = false;
            bool low = false;
            bool spec = false;
            char currentChar;
            if (!(input.Length >= 2))
            {
                return false;
                throw new ArgumentException("Length of the Password is must be greater then 2");
            }

            for (int i = 0; i < input.Length; i++)
            {
                currentChar = input[i];
                if (char.IsDigit(currentChar))
                {
                    num = true;
                }
                else if (char.IsUpper(currentChar))
                {
                    upp = true;
                }
                else if (char.IsLower(currentChar))
                {
                    low = true;
                }
                else if (!char.IsLetterOrDigit(currentChar))
                {
                    spec = true;
                }

                if (num && upp && low && spec)
                {
                    return true;
                }
                throw new ArgumentException("password not valid");
            }
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
                throw new ArgumentException("Empty Password");
            }
            return false;
        }
        public static bool PasswordCheck(string input)
        {
            return VerifyPassword(input);
        }
    }
}
