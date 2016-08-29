using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class BankTest
    {
        static void Main(string[] args)
        {
           // Customer cust1 = new Customer("Tah Ah Kow", "20,Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            //Customer cust2 = new Customer("Kim Lee Keng","2.Rich View", "XXX9F", new DateTime(1993, 10, 11));
            //BankAccount_3 bankAcc1 = new BankAccount_3("001-001-001", "Tan Ah Kow", 2000);
            //BankAccount_3 bankAcc2 = new BankAccount_3("001-001-001", "Kim Keng Lee", 5000);

            //Console.WriteLine(bankAcc1.Show());
            //bankAcc1.Deposit(500);
            //Console.WriteLine(bankAcc1.Show());
            //bankAcc1.Withdraw(200);
            //Console.WriteLine(bankAcc1.Show());
            //bankAcc1.Transfer(300, bankAcc2);
            //Console.WriteLine(bankAcc1.Show());
            //Console.WriteLine(bankAcc2.Show());

            //3.2 Workshop
            Customer cust1 = new Customer("Tah Ah Kow", "20,Seaside Road", "XXX20", new DateTime(1989, 10, 11));
            Customer cust2 = new Customer("Kim Lee Keng", "2.Rich View", "XXX9F", new DateTime(1993, 10, 11));
            BankAccount_3 bankAcc1 = new BankAccount_3("001-001-001", cust1, 2000);
            BankAccount_3 bankAcc2 = new BankAccount_3("001-001-001", cust2, 5000);

            bankAcc1.Deposit(500);
            Console.WriteLine(bankAcc1.Show());
            bankAcc1.Withdraw(200);
            Console.WriteLine(bankAcc1.Show());
            bankAcc1.Transfer(300, bankAcc2);
            Console.WriteLine(bankAcc1.Show());
            Console.WriteLine(bankAcc2.Show());
        }
    }
}
