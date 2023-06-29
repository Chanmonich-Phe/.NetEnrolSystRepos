using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemPHE
{
    public class Address
    {
        public string number { get; set; }
        public string street { get; set; }
        public string suburb { get; set; }
        public string postCode { get; set; }
        public string state { get; set; }

        public Address(string number, string street, string suburb, string postCode, string state)
        {
            this.number = number;
            this.street = street;
            this.suburb = suburb;
            this.postCode = postCode;
            this.state = state;
        }

        public override string ToString()
        {
            return "number -> " + number + "street-> " + street + "suburb-> " + suburb + "postCode -> " + postCode + "state-> " + state;
        }
    }
}
