namespace carvedrock.bl.refactoring.SimplifyingConditionalExpressions
{
	public enum Season
	{
		Winter, Spring, Summer, Fall
	}

	public class ConsolidateConditionalExpressions
	{
		public double SeasonSale(Season season)
		{
			if (season == Season.Winter || season == Season.Summer)
			{
				return 0.50;
			}
			else if (season == Season.Spring)
			{
				return 0.10;
			}
			if (season == Season.Fall)
			{
				return 0.20;
			}
			else
			{
				return 0;
			}
		}
	}
}