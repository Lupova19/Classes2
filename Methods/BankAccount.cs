﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }
        public void Print()
        {
            Console.WriteLine($"Account:{this.ID}, balance:{this.balance}!");
        }
    }
}
