using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class BankBranch
    {
        private string branchName;
        private string branchManager;
        private ArrayList listOfBankAccount; 

        public string BranchName
        {
            get
            {
                return branchName;
            }
        }
        public string BranchManager
        {
            get
            {
                return branchManager;
            }
        }
        public BankBranch(string brName,string brManager)
        {
            branchName = brName;
            branchManager = brManager;
            listOfBankAccount = new ArrayList();

        }
        public void AddAccount(BankAccount_3 bankAccount)
        {
            listOfBankAccount.Add(bankAccount);
        }
        public void PrintAccounts()
        {
            Console.WriteLine("Bank Account No\t Customer Name\tAddress\tPassportNo\tAge\tBalance");
           for(int i=0;i<listOfBankAccount.Count;i++)
           {
               Console.WriteLine(listOfBankAccount[i]);
           }
        }
        public void CreditInterest()
        {
            for(int i=0;i<listOfBankAccount.Count;i++)
            {
                BankAccount_3 a = (BankAccount_3)listOfBankAccount[i];
                a.CreditInterest();
            }
        }
        public void PrintCustomers()
        {
            ArrayList cust = new ArrayList();
            Console.WriteLine("Customer Name\tAddress\tPassportNo\tAge");
            for(int i =0;i<listOfBankAccount.Count;i++)
            {
                BankAccount_3 b = (BankAccount_3)listOfBankAccount[i];
                Customer c = b.AccountHolder;
                int numIndex = cust.IndexOf(c);
                if (numIndex < 0)
                {
                    cust.Add(c);
                }
            }
            for(int j=0;j<cust.Count;j++)
            {
                Console.WriteLine("{0}" ,cust[j]);
            }
        }
        public double TotalDeposit()
        {
            double total =0;
            for(int i=0;i<listOfBankAccount.Count;i++)
            {
                BankAccount_3 b =(BankAccount_3) listOfBankAccount[i];
                total += b.Balance;
            }
            return total;
        }
        public double TotalInterestPaid()
        {
            double totalInterest = 0;
            for(int i=0;i<listOfBankAccount.Count;i++)
            {
                BankAccount_3 b = (BankAccount_3)listOfBankAccount[i];
                double intr = b.CalculateInterest();
                if (intr > 0)
                    totalInterest += intr;
            }
            return totalInterest;
        }
        public double TotalInterestEarned()
        {
            double total = 0;
            for(int i=0;i<listOfBankAccount.Count;i++)
            {
                BankAccount_3 a =(BankAccount_3) listOfBankAccount[i];
                double intr = a.CalculateInterest();
                if(intr < 0)
                {
                    total += (-intr);
                }
            }
            return total;
        }
        public class App
        {
            public static void Main()
            {
                BankBranch branch = new BankBranch("KOKO Bank Branch", "Tan Mon Nee");
                Customer cust1 = new Customer("Tan Ah Kaow", "2 Rich Street", "P345123", 40);
                Customer cust2 = new Customer("Aye Me Ko", "88 Fatt Road", "P678678", 54);
                Customer cust3 = new Customer("Alex Gold", "91 Dream Cove", "P333221", 34);
                branch.AddAccount(new OverdraftAccount("01230124", cust1, -2));
                branch.AddAccount(new CurrentAccount("c1230125", cust2, 2000));
                branch.AddAccount(new CurrentAccount("c1230666", cust3, 500));

               branch.PrintAccounts();
                branch.PrintCustomers();
               Console.WriteLine(branch.TotalInterestEarned());
                Console.WriteLine(branch.TotalInterestPaid());
               branch.CreditInterest();
              branch.PrintAccounts();
                
            }
        }
    }
}
