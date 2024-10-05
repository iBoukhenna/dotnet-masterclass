using carvedrock.bl.Conventions.LINQ.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LINQ
{
    public class RenameProperties
    {
        public List<Customer> Customers { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
        public RenameProperties()
        {
            var userOrders =
                from customer in Customers
                join order in Orders on customer.Id equals order.CustomerId
                select new { customer.Name, order.Id };
        }
    }
}
