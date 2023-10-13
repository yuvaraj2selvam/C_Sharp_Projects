using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class Display
    {
        public Display() {
          
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n \t\t\t\t\t ATM");
            Program.accounts.Add(new account("yuvaraj", "123456", 10000));
            Console.Write("Enter Account Number :");
            string account_number = Console.ReadLine();
            Console.Write("Enter Pin Number :");
            string account_pin = Console.ReadLine();
            if (!pinValidator.check(account_pin))
                Console.WriteLine("Pin you entered cannot be Procedded ,Try again");
           
            new account_verification(account_number, account_pin);

        }
    }
}
