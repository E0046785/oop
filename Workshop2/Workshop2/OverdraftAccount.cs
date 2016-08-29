using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
  public  class OverdraftAccount:BankAccount_3
    {
      private static double overdraftInterest = 6;
      private static double interestRate = 0.25;

      public OverdraftAccount(string number,Customer holder,double bal):base(number,holder,bal)
      {

      }
      public new bool Withdraw(double amount)
      {
          balance = balance - amount;
          return true;
          
      }
      public new double CalculateInterest()
      {
          return (Balance > 0) ? (Balance * interestRate / 100) : (Balance * overdraftInterest / 100);
      }


      public string Show()
      {
          string customerInfo = String.Format
                               ("[OverdraftAccount:={0},Account Holder={1},Balance={2}]", AccountNumber, AccountHolder, Balance);
          return customerInfo;
      }

    }
}
