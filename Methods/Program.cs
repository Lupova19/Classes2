using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            List<BankAccount> accounts = new List<BankAccount>();

            account.ID = 1;
            account.Deposit(15);
            account.Withdraw(5);

            account.Print();
        }
    }
}
