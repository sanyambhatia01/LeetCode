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
            bool number = false;
            bool upperLetter = false;
            bool lowerLetter = false;
            bool specialCharacter = false;
            int minimumLength = 8;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Empty Password");
            }

            if (!(input.Length >= minimumLength))
            {
                throw new ArgumentException("Length of the Password is must be greater than " + minimumLength );
            }

            foreach (char currentChar in input)
            {  
                if (char.IsDigit(currentChar))
                {
                    number = true;
                }
                else if (char.IsUpper(currentChar))
                {
                    upperLetter = true;
                }
                else if (char.IsLower(currentChar))
                {
                    lowerLetter = true;
                }
                else if (!char.IsLetterOrDigit(currentChar))
                {
                    specialCharacter = true;
                }
                if (number && upperLetter && lowerLetter && specialCharacter)
                {
                    return true;
                }
            }
            throw new ArgumentException("password not valid");
        }
        public static bool PasswordCheck(string input)
        {
            return VerifyPassword(input);
        }
    }
}
