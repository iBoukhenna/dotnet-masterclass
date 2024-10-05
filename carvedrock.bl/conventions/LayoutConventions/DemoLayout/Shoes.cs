using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LayoutConventions.DemoLayout
{
	public class Shoes
	{
		public string Name { get; } = null!;
		public double Price { get; set; }
		public int Size { get; }
		public string Color { get; }
		public bool IsWaterproof { get; }

		public Shoes(string name, double price, int size, string color, bool isWaterproof)
		{
			Name = name;
			Price = price;
			Size = size;
			Color = color;
			IsWaterproof = isWaterproof;
		}
	}
}