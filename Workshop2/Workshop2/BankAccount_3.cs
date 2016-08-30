using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
   public class BankAccount_3
    {
		private string accountNumber;
		//private string accountHolder;
        private Customer accountHolder;
		//private double balance;
       //workshop 4
        protected double balance;
        //Workshop 4
        private double interestRate;
          
		
        //public BankAccount_3(string accNumber, string holder, double bal)
        //{
        //    accountNumber = accNumber;
        //    accountHolder = holder;
        //    balance= bal;
			
        //}
        //3.2 workshop
        public BankAccount_3(string accNumber,Customer holder, double bal)
        {
            accountNumber = accNumber;
            accountHolder = holder;
            balance = bal;

        }

        //workshop 4
        public double InterestRate
        {
            get
            {
                return interestRate;
            }
        }

		//properties

		public string AccountNumber
		{
			get
			{
			   return accountNumber;
			}
		}
		public Customer AccountHolder
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
        //public bool Withdraw(double amount)
        //{
        //    if(amount < balance )
        //    {
        //        balance = balance-amount;
        //        return true;
        //    }
        //    else
        //    {
        //     Console.Error.WriteLine("Withdrawl for {0} is unsuccessful",AccountHolder);
        //     return false;
        //    }
        //}

        public virtual bool Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance = balance - amount;
                return true;
            }
            else
            {
                Console.Error.WriteLine("Withdrawl for {0} is unsuccessful", AccountHolder);
                return false;
            }
        }
		public void Deposit(double amount)
		{
			balance = balance + amount;
		}
        public bool Transfer(double amount, BankAccount_3 anotherAccount)
		{
			if(Withdraw(amount))
			{
			   anotherAccount.Deposit(amount);
			   return true;
			}
			else
			{
                Console.Error.WriteLine("Transfer to {0} is unsuccessful", anotherAccount.AccountHolder);
                return false;
			}
		}
        //workshop 4
        public double CalculateInterest()
        {
            return (Balance * 1 / 100);
        }
        public void CreditInterest()
        {
            Deposit(CalculateInterest());
        }


        //public string Show()
        //{
        //    string customerInfo = String.Format
        //                         ("[Account Number={0},Account Holder={1},Balance={2}]", AccountNumber, AccountHolder, Balance);
        //    return customerInfo;
        //}
        public override string ToString()
        {
            string customerInfo = String.Format
                                 ("{0}\t{1}\t{2}\t", AccountNumber, AccountHolder, Balance);
            return customerInfo;
        }
    }
}
