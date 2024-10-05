using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LayoutConventions
{
	public class Indentation
	{
		public double PriceWithDiscount(double price)
		{
			if ((price > 100) && (price < 400))
			{ // 1 tab
				price -= price * 0.30; // 2 tabs
			} // 1 tab
			else if (price >= 400)
			{
				price -= price * 0.60;
			}
			return price;
		}
	}
}
