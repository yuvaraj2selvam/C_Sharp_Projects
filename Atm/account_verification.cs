﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class account_verification
    {
        public account_verification(string accno,string pinno)
        {
            foreach (var obj in Program.accounts)
            {
                if(obj.Accountnumber==accno && obj.Pin==pinno)
                {
                    Console.WriteLine("Login Success");
                    Console.WriteLine("Press Enter");
                    Console.Read();
                    Console.Clear();
                    Console.WriteLine(obj.Accountname);
                    Console.WriteLine(obj.Balance);
                }
                else
                {
                    Console.Clear ();
                    Console.WriteLine("Login Failed ,please try Again");
                    new Display();
                }
            }
        }
    }
}
