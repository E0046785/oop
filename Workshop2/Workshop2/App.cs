using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    public class App:BankAccount_3
    {
        Customer customer1 = new Customer("Tan Ah Kow", "2,Rich Street", "P123545", 20);
        Customer customer2 = new Customer("Kim May Mee", "2,Gold Road", "P334422", 60);

        BankAccount_3 a1 = new BankAccount_3("S000352", customer1, 2000);
          
          
    }
}
