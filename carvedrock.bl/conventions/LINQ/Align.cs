using carvedrock.bl.Conventions.LINQ.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LINQ
{
    public class Align
    {
        public List<Product> Products { get; set; } = new();
        public Align()
        {
            var seasonProducts = from product in Products where product.Season == "Winter" select product.Name;

            // or

            var sportProducts = from product in Products
                where product.Sport == "Hiking" select product.Name;
        }
    }
}
