using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
   public class Customer
    {
        private string name;
        private string address;
        private string passportNo;
        private DateTime dateOfBirth;


        public Customer(string name, string address, string passportNo, DateTime dob):this(name,address,passportNo)
        {
           
            this.dateOfBirth = dob;
           
        }
        public Customer(string name, string address, string passportNo)
        {
            this.name = name;
            this.address = address;           
            this.passportNo = passportNo;
        }
        public Customer(string name, string address, string passportNo,int age):this(name,address,passportNo)
        {
            this.dateOfBirth = new DateTime(DateTime.Now.Year - age, 1, 1);
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
       public int Age
        {
            get
            {
                return DateTime.Now.Year - dateOfBirth.Year;
            }
        }
        public string Show()
       {
           string customerInfo = String.Format
                                ("[Customer:name={0},address={1},passport={2},age={3}]", name, address, passportNo, Age);
           return customerInfo;
        }
       



        public class App {
 
        public static void Main() {
            Customer cus1 = new Customer("Tan Ah Kow", "2 Rich Street",
                                      "P123123", 20);
            Customer cus2 = new Customer("Kim May Mee", "89 Gold Road",
                                      "P334412", 60);
 
            BankAccount_3 a1 = new BankAccount_3("S0000223", cus1, 2000);
            Console.WriteLine(a1.CalculateInterest());
            OverdraftAccount a2 = new OverdraftAccount("O1230124", cus1, 2000);
            Console.WriteLine(a2.CalculateInterest());
            CurrentAccount a3 = new CurrentAccount("C1230125", cus2, 2000);
            Console.WriteLine(a3.CalculateInterest());
        }
    }
}
