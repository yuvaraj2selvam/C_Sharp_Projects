using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class Details
    {
        public Details(account obj)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Account name: {0}", obj.Accountname);
                Console.WriteLine("Account number: {0}", obj.Accountnumber);
                Console.WriteLine();
                Console.WriteLine("1. Account balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your Choice :");
                int n = Convert.ToInt32(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Account balance: {0}", obj.Balance);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Enter the Amount to Deposit");
                            int dmoney = Convert.ToInt32(Console.ReadLine());
                            obj.Balance += dmoney;
                            Console.WriteLine("Successfully Deposited");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Enter the Amount to Withdraw");
                            int wmoney = Convert.ToInt32(Console.ReadLine());
                            if (obj.Balance >= wmoney)
                            {
                                obj.Balance -= wmoney;
                                Console.WriteLine("Money Withdrawn Successfully");
                            }
                            else
                            {
                                Console.WriteLine("Money Withdrawal Unsuccessful");
                                Console.WriteLine("Check your Account Balance");
                            }
                            break;
                        case 4:
                            // Handle transfer logic here
                            break;
                        case 5:
                            return; // Exit the loop and the method
                       
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    
                         }


                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
