using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class BankAccount2
    {
        private string accountNumber;
		private string accountHolder;
		private double balance;

		public BankAccount2():this("000-000-000","NONAME",0)
		{

		}
		public BankAccount2(string accNumber,string holder,double bal)
		{
			accountNumber = accNumber;
			accountHolder = holder;
			balance= bal;
			
		}
		//properties

		public string AccountNumber
		{
			get
			{
			   return accountNumber;
			}
		}
		public string AccountHolder
		{
			get
			{
			  return accountHolder;
			}
			set
			{
			   accountHolder = value;
			}
		}
		public double Balance
		{
			get
			{
			  return balance;
			}
		}
		public bool Withdraw(double amount)
		{
		    if(amount < balance )
			{
				balance = balance-amount;
				return true;
			}
			else
			{
			 Console.Error.WriteLine("Withdrawl for {0} is unsuccessful",AccountHolder);
			 return false;
			}
		}
		public void Deposit(double amount)
		{
			balance = balance + amount;
		}
    }
}
