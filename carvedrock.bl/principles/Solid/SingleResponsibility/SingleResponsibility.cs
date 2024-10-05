using System;
namespace carvedrock.bl.principles.Solid
{
	public class Circle
	{
		private double Radius = 1;

		public double Area()
		{
			return 3.1415 * Math.Pow(Radius, 2);
		}

		public double Circunference()
		{
			return 2 * 3.1415 * Radius;
		}
    }
}

