using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities
{
    class OrderDetail
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public double SubTax { get; set; }
        public double SubPrice { get; set; }
        public double SubWeight { get; set; }

        int CalcSubTotal()
        {

            return 0;
        }
        int CalcWeight()
        {

            return 0;
        }
    }
}
