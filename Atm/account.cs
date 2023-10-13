using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class account
    {
        private string accountnumber;
        private string accountname;
        private int balance=0;
        private string pin;

        public string Accountnumber { get { return accountnumber;} set {accountnumber=value;} }
        public string Accountname
        {
            get { return accountname; }
            set { accountname = value; }
        }
        public int Balance { get { return balance; } set { balance = value; } }
        public string Pin { get { return pin; } set { pin = value; } }
        public string gen_no()
        {
            string acno="";
            int i = 0;
            while(i<10)
            {   
                Random obj = new Random();
                acno +=obj.Next(0,10).ToString();
                i++;
            }
            return acno;
        }
        public account(string name,string pin,int bal)
        {
            this.accountnumber = "123"; 
            this.pin = pin;
            this.accountname = name;
            this.balance = bal;

            Console.WriteLine("Your Account number :{0}", Accountnumber);
        }

       
    }
}
