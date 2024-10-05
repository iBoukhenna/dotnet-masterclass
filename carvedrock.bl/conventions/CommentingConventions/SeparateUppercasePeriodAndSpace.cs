using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.CommentingConventions
{
    public class SeparateUppercasePeriodAndSpace
	{
		public static double PriceWithDiscount(double price) //the query applies a discount to a specific price, according to a minimum and maximum margin! And returns the new price
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
