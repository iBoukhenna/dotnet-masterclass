namespace carvedrock.bl.principles.DRY
{
	public class DRY
	{
		public DRY()
		{
			BackPack backPack = new("Tor 85 Litre Rucksack", 79.99, 85, 200, true);
			Shoes shoe = new("Salomon X Ultra", 119, 10, "black", true);

			backPack.Price = PriceWithDiscount(backPack.Price);
			shoe.Price = PriceWithDiscount(shoe.Price);
		}

		public double PriceWithDiscount(double price)
		{
			if ((price > 100) && (price < 400))
			{
				price -= price*0.30;
			} else if(price >= 400)
			{
				price -= price*0.60;
			}
			return price;
		}
	}
}

