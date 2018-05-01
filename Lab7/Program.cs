using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            IsName();
            IsPhone();
            IsDate();
            IsEmail();
        }

        static void Welcome()
        {
            Console.WriteLine("Thank you for using this program!");

        }
        static bool IsName()
        {
            while (true)
            {
                Console.WriteLine("Please enter your name. Ex: Mohammed Rahman");
                string UsersName = Console.ReadLine();


                if (Regex.IsMatch(UsersName, @"[A-Z]{1}([A-Za-z]){1,30}") == true)
                {
                    Console.WriteLine($"Thank you for your name, {UsersName}!");
                    return true;
                }
                else
                {
                    Console.WriteLine("That was not a valid input.");
                }

            }

        }

        static bool IsEmail()
        {
            while (true)
            {
                Console.WriteLine("Please enter your email address. Ex: local-part@domain.com");
                string UsersEmailAddress = Console.ReadLine();

                if (Regex.IsMatch(UsersEmailAddress, @"[\w\.]{1,}@[\w.]{1,}.\w{2,}") == true)
                {
                    Console.WriteLine("Thank you for entering your email address!");
                    return true;
                }
                else
                {
                    Console.WriteLine("That was not a valid input.");
                }
            }
        }

        static bool IsPhone()
        {
            while (true)
            {
                Console.WriteLine("Please enter your phone number. Ex: 313-555-4444");
                String UsersPhoneNumber = Console.ReadLine();

                if (Regex.IsMatch(UsersPhoneNumber, @"^\d{3}[-]\d{3}[-]\d{4}$") == true)
                {
                    Console.WriteLine("Thank you for entering your phone number!");
                    return true;
                }
                else
                {
                    Console.WriteLine("That was not a valid input.");
                }
            }
        }

        static bool IsDate()
        {
            while (true)
            {
                Console.WriteLine("Please enter a date. Ex: 02/15/1999");
                string UsersDate = Console.ReadLine();
                if (Regex.IsMatch(UsersDate, @"^\d{2}[/]\d{2}[/]\d{4}$") == true)
                {
                    Console.WriteLine("Thank you for entering a date!");
                    return true;
                }
                else
                {
                    Console.WriteLine("That was not a valid input.");
                }


            }
        }
    }
}