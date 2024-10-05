using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LayoutConventions.DemoLayout
{
	public class DemoLayout
	{
		public DemoLayout()
		{
			BackPack backPack = new("Tor 85 Litre Rucksack", 79.99, 85, 200, true);
				Shoes shoe = new("Salomon X Ultra", 119, 10, "black", true);

			backPack.Price = PriceWithDiscount(backPack.Price);
			 shoe.Price = PriceWithDiscount(shoe.Price);
		}

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
