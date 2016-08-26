using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    class Customer
    {
        private string name;
        private string address;
        private string passportNo;
        private DateTime dob;
        private int age;

        public  Customer(string name,string address,string passportNo,DateTime dob)
        {
            this.name = name;
            this.address = address;
            SetAge(dob);
            this.passportNo = passportNo;
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
        public int GetAge()
        {            

            return age;
        }
        public void SetAge(DateTime dob)
            
        {
            int  thisYear= DateTime.Now.Year;
            
            this.age = thisYear-dob.Year;
       
        }

    }
}
