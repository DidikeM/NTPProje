using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int AddressID { get; set; }
        //public List<Order> Orders { get; set; }

        public Customer()
        {

        }
    }
}
