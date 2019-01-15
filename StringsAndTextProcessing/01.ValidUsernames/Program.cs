using System;
using System.Collections.Generic;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            List<string> validUsernames = new List<string>();

            for (int i = 0; i < usernames.Length; i++)
            {
                string currentUsername = usernames[i];

                if (currentUsername.Length > 2 && currentUsername.Length < 17)
                {
                    string resultChar = "";

                    for (int j = 0; j < currentUsername.Length; j++)
                    {
                        char currChar = currentUsername[j];

                        if (char.IsDigit(currChar) || char.IsLetter(currChar) || currChar == '-' || currChar == '_')
                        {
                            resultChar += currChar;
                            continue;
                        }

                        else if (!(char.IsDigit(currChar) || char.IsLetter(currChar) || currChar == '-' || currChar == '_'))
                        {
                            break;
                        }
                    }

                    if (resultChar == currentUsername)
                    {
                        validUsernames.Add(currentUsername);
                    }
                }
            }
            foreach (var username in validUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
