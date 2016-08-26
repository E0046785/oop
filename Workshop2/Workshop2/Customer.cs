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
        private DateTime dateOfBirth;

        public  Customer(string name,string address,string passportNo,DateTime dob)
        {
            this.name = name;
            this.address = address;
            this.dateOfBirth = dob;
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
        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }
        public void SetDateOfBirth(DateTime dob)
        {
            this.dateOfBirth = dob;
       
        }

    }
}
