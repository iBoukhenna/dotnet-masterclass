using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LayoutConventions
{
    public class OneStatementPerLine
    {
        public OneStatementPerLine()
        {
            string productName = "Hello Summer T-Shirt";

            double productPrice, discount; // Declaration
            productPrice = 5.99; discount = 0.3; // Assignment
            productPrice = productPrice * discount; productPrice = Math.Round(productPrice, 2);


            Console.WriteLine($"Name:{productName}, Price:{productPrice}");
        }
    }
}
