using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Class1
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneNo { get; set; }
        public string email { get; set; }
        public Class1()
        {

        }

        public Class1(string name, string address, string city, string state, string zip, string phoneNo, string email)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNo = phoneNo;
            this.email = email;
        }
        
        
    }
}
