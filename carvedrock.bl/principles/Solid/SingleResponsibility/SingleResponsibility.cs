using System;
namespace carvedrock.bl.principles.Solid
{
	public class Circle
	{
		private double Radius;

		public double Area()
		{
			return 3.1415 * Math.Pow(Radius, 2);
		}

		public double Circunference()
		{
			return 2 * 3.1415 * Radius;
		}

		public void PlotCircleOnCanvas(Canvas canvas)
		{
			// This does not belong here!
		}
    }
}

