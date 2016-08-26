using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class BankAccount
    {
        private string accountNumber;
        private Customer accountHolderName;
        private double balance;
     
        public  BankAccount(string accountNumber,Customer accountHolderName,double balance)
        {
            this.accountNumber=accountNumber;
            this.accountHolderName = accountHolderName;
             this.balance=balance;


        }
        public string getAccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        public Customer getAccountHolderName
        {
            get
            {
                return accountHolderName;
            }
            set
            {
                accountHolderName = value;
            }
        }
        public double GetBalance()
        {
            return balance;

        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public double Withdraw(double amount)
        {
            if (amount > GetBalance())
            {
                Console.WriteLine("Cannot withdraw more than balance");
                return 0.00;

            }
            else

                this.balance = GetBalance() - amount;
              return balance;
            
        }
        public void Deposit(double amount)
        {
            SetBalance(this.balance + amount);
        }
        public void TransferTo(double amount,BankAccount anotherBankAccount)
        {
            Console.WriteLine("{0} is transfer to account {1} ", amount, anotherBankAccount);
        }
        public double Show()
        {

            return GetBalance();
        }
    }
    class BankTest
    {
        static void Main(string[] args)
        {
            //BankAccount a = new BankAccount("001-001-001",, 2000);
            //BankAccount b = new BankAccount("001-001-002", "Kim Keng Lee", 5000);
            Customer y = new Customer("Tan Ah Kow","20,Seaside Road","XXX20",new DateTime(1989,10,11));
            Customer Z = new Customer("kim Lee Keng", "2,Rich view", "XXX9F", new DateTime(1993, 10, 11));
            BankAccount a = new BankAccount("001-001-001",y, 2000);
            BankAccount b = new BankAccount("001-001-002",Z, 5000);
            
            Console.WriteLine(a.Show());
            Console.WriteLine(y.GetAge());
            Console.WriteLine(Z.GetAge());

            Console.WriteLine(b.Show());
            a.Deposit(100);
            Console.WriteLine(a.Show());
            a.Withdraw(200);
            Console.WriteLine(a.Show());
            a.TransferTo(300, b);
           Console.WriteLine(a.Show());
          Console.WriteLine(b.Show());
        }
    }
}
