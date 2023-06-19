using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPMS
{
    class CarOrders
    {
        public int cid { get; set; }
        public int crid { get; set; }
        public string crname { get; set; }
        public decimal price { get; set; }
        public int noc { get; set; }
        public decimal total { get; set; }
        public string payment { get; set; }
        public string status { get; set; }
        public string odate { get; set; }

        public CarOrders(int cid, int crid, string crname, decimal price, int noc, decimal total, string payment, string status, string odate)
        {
            this.cid = cid;
            this.crid = crid;
            this.crname = crname;
            this.price = price;
            this.noc = noc;
            this.total = total;
            this.payment = payment;
            this.status = status;
            this.odate = odate;
        }
    }
}
