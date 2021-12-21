using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public Customer Customer { get; set; }
        public Payment Payments { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Order()
        {

        }

        int CalcTax()
        {

            return 0;
        }

        int CalcTotal()
        {

            return 0;
        }

        int CalcTotalWeight()
        {

            return 0;
        }
    }
}
