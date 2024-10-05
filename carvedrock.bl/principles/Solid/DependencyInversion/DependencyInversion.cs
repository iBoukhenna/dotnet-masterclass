using System;
namespace carvedrock.bl.principles.Solid.DependencyInversion
{
	public class DependencyInversion
	{
		public DependencyInversion()
		{
			SqlServerDatabase db = new();

			SalesReport monthlyReport = new(db);

			monthlyReport.CreateReport(DateTime.Now.AddMonths(-1), DateTime.Now);
			monthlyReport.SaveReport();
		}
	}
}