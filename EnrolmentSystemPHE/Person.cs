using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemPHE
{
    public abstract class Person
    {
        public string name { get; set; }
        public string email { get; set; }
        public string telNum { get; set; }

        public Address Address { get; set; }


        public Person(string name, string email, string telNum, string number, string street, string suburb, string postCode, string state)
        {
            this.name = name;
            this.email = email;
            this.telNum = telNum;
            Address address = new Address(number, street, suburb, postCode, state);
        }

        public void setAddress(string number, string street, string suburb, string postCode, string state)
        {
            Address = new Address(number, street, suburb, postCode, state);
        }
    }
}
