using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LayoutConventions
{
    public class BackPack //Complete demo
	{
		// Correct indentation
		// Separate declarations
		private List<string> _sizes = new() { "S", "L", "XL" };
		private List<string> _colors = new() { "Green", "Blue", "Black" };
		// Separate statements (properties)
		public string Name { get; } = null!;
		public double Price { get; set; }
		public int Capacity { get; }
		public double Weight { get; }
		public bool IsWaterproof { get; }
		// Blank line added here!
		public BackPack(string name, double price, int capacity, double weight, bool isWaterproof)
		{
			Name = name;
			Price = price;
			Capacity = capacity;
			Weight = weight;
			IsWaterproof = isWaterproof;
		}
		public string Details()
		{
			var sizes = string.Join(',', _sizes);
			var colors = string.Join(',', _colors);
			return $"Backpack (Name={Name}, Price={Price:C}, Capacity:{Capacity}, Sizes:{sizes}, Colors:{colors})";
		}
		// Check the correct use of parentheses in
		// conventions\LayoutConventions\DemoLayout\DemoLayout.cs
		// -> PriceWithDiscount.
	}
}
