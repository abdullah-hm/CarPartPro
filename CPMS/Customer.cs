using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPMS
{
    class Customer
    {
        // variable declaration
        public string fullname { get; set; }
        public string mobileno { get; set; }
        public string nic { get; set; }
        public string address { get; set; }
        public string dob { get; set; }
        public string username { get; set; }
        public string password { get; set; }
         
        // constructor
        public Customer(string fullname, string mobileno, string nic, string address, string dob, string username, string password)
        {
            this.fullname = fullname;
            this.mobileno = mobileno;
            this.nic = nic;
            this.address = address;
            this.dob = dob;
            this.username = username;
            this.password = password;
            
        }

         
    }

     
}
