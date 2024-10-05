using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.CommentingConventions
{
    internal class FunnyComments
    {
        // When I wrote this, only a higher being and I understood what I was doing
        // Now, only the higher being knows

        // If this comment is removed the program will blow up

        // No comments for you
        // It was hard to write
        // So it should be hard to read
        public static double PriceWithDiscount(double price)
        { // Avoid losing money :)!
            if ((price > 100) && (price < 400)) // This solves issue 234
            {
                price -= price * 0.30; 
            }
            else if (price >= 400) // A lot?
            {
                price -= price * 0.60; // Losing money?
            }
            return price; // Maybe return the same price for some products
        }
    }
}
