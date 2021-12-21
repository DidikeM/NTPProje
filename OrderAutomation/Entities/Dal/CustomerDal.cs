using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderAutomation.Entities.Dal
{
    class CustomerDal:IRepository<Customer>
    {
        public List<Customer> GetAll()
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Customers.ToList();
            }
        }

        public Customer GetByID(int ID)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Customers.FirstOrDefault(p => p.ID == ID);
            }
        }

        public void Add(Customer customer)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void Update(Customer customer)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(customer);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delate(Customer customer)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                var entity = context.Entry(customer);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Customer> GetByName(string key)
        {
            using (OrderAutomationContext context = new OrderAutomationContext())
            {
                return context.Customers.Where(p => p.Name.Contains(key)).ToList();
            }
        }
    }
}
