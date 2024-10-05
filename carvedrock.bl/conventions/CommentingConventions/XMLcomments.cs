using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.CommentingConventions
{
    internal class XMLcomments
    {
		/// <summary>
		/// Applies a discount to a specific price,
		/// according to a minimum and maximum margin.
		/// </summary>
		/// <param name="price">The price of specific product.</param>
		/// <returns>A double that represents the price with the discount.</returns>
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
