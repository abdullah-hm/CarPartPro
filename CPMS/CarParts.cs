using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPMS
{
    class CarParts
    {

        public string carname { get; set; }
        public string partname { get; set; }
        public string modelno { get; set; }
        public string color { get; set; }
        public string price { get; set; }
        public string status { get; set; }

        public CarParts(string carname, string partname, string modelno, string color, string price, string status)
        {
            this.carname = carname;
            this.partname = partname;
            this.modelno = modelno;
            this.color = color;
            this.price = price;
            this.status = status;
        }
    }
}
