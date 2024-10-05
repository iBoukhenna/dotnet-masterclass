using carvedrock.bl.Conventions.LINQ.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LINQ
{
    public class WhereBefore
    {
        public List<Order> Orders { get; set; } = new();
        public WhereBefore()
        {
            var scoreItems =
                from order in Orders
                from item in order.Items!
                where item > 100
                orderby item descending
                select new { CustomerId = order.CustomerId, Expensiveitem = item };
        }
    }
}
