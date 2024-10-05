using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LayoutConventions.DemoLayout
{
	public class BackPack
	{
		private List<string> _sizes = new List<string>() { "S", "L", "XL" };
	  private List<string> _colors = new List<string>() { "Green", "Blue", "Black" };
		public string Name { 
			get; 
		} = null!;
        public double Price
        {
			get;
			set;
		}
	   public int Capacity { get; }
	 public double Weight { get; }
	  public bool IsWaterproof { get; }

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
	}
}
