using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPMS
{
    class Car
    {
        // variable declaration
        public string name { get; set; }
        public string brand { get; set; }
        public string year { get; set; }
        public string type { get; set; }
        public string color { get; set; }
        public string price { get; set; }
        public string status { get; set; }

        // constructor 
        public Car( string name, string brand, string year, string type, string color, string price, string status)
        {
             
            this.name = name;
            this.brand = brand;
            this.year = year;
            this.type = type;
            this.color = color;
            this.price = price;
            this.status = status;
        }
    }
}
