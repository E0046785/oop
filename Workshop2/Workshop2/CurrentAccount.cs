using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    public class CurrentAccount : BankAccount_3
    {
        public static double interestRate = 0.25;
        public CurrentAccount(string number,Customer holder,double bal):base(number,holder,bal)
        {

        }
        public new double CalculateInterest()
        {
            return (Balance * interestRate / 100);
        }
        public string Show()
        {
            string customerInfo = String.Format
                                 ("[Account Number={0},Account Holder={1},Balance={2}]", AccountNumber, AccountHolder, Balance);
            return customerInfo;
        }
    }
}
