using System;

namespace _04.passwordValidator
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var check = 0;
            string password = Console.ReadLine();
            var passwordLength = PasswordLength(password, check);
            var passContent = PasswordContent(password, check);
            var passDigits = PasswordDigits(password, check);

            if (passwordLength == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (passContent == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (passDigits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");

            }   
            if (passDigits == true && passContent == true && passwordLength == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool PasswordDigits(string password, int check)
        {
            int charNums = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];
                
                if (char.IsDigit(currentChar))
                {
                    charNums++;
                }
            }
            if (charNums < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private static bool PasswordContent(string password, int check)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];
                if (char.IsDigit(currentChar) || char.IsLetter(currentChar))
                {
                    continue;
                }
                
                else
                {
                    
                    return false;
                }

            }
            return true;
        }

        private static bool PasswordLength(string password, int check)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }
    }
}
