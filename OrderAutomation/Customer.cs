using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation
{
    class Customer
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; }

        public Customer()
        {

        }
    }
}
