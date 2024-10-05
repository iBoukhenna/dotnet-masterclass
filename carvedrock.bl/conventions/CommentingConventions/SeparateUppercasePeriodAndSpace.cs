using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.CommentingConventions
{
    public class SeparateUppercasePeriodAndSpace
	{
		// Place the comment on a separate line, not at the end of a line of code.
		// Begin comment text with an uppercase letter.
		// End comment text with a period.
		// Insert one space between the comment delimiter (//) and the comment text, as shown in the following example.
		
		// Result:

		// The query applies a discount to a specific price,
		// according to a minimum and maximum margin!
		// Returns the new price.
		public static double PriceWithDiscount(double price)
		{
			if ((price > 100) && (price < 400))
			{
				price -= price * 0.30;
				
			}
			else if (price >= 400)
			{
				price -= price * 0.60;
			}
			return price;
		}
	}
}
