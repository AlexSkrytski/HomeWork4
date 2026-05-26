using System.Text.RegularExpressions;

namespace HomeWork4
{
    internal class Program
    {
        class Account
        {

            public string User = string.Empty;
            public string Password = string.Empty;
            public Account()
            {
                Console.WriteLine("Input Login:");
                string User = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Input new password:");
                string password = Console.ReadLine() ?? string.Empty;
                
                if (Regex.IsMatch(password, @"(?=.{8,30})(?=(.*\d){1,})(?=(.*\W){1,})(?=.*[a-z])(?=.*[A-Z])"))

                //Is at least 8-30 characters long.

                //Contains at least one digit.

                //Contains at least one special(non - alphanumeric) character.

                //Contains at least one lowercase letter.

                //Contains at least one uppercase letter.

                {
                    Console.WriteLine("Account created!");
                }
                else
                {
                    Console.WriteLine("Invalid password!");
                }
            }
        }
        static void Main(string[] args)
        {

            Account firstAccout = new Account();

        }
    }
}
