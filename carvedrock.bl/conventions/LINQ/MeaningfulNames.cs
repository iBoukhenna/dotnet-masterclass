using carvedrock.bl.Conventions.LINQ.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LINQ
{
    public class MeaningfulNames
    {
        public List<Product> products = new();
        public MeaningfulNames()
        {
            var climbingProducts = from product in products
                                   where product.Sport == "Climbing"
                                   select product;
        }
    }
}
