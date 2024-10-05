using System;
namespace carvedrock.bl.principles.Solid.DependencyInversion
{
	public class DependencyInversion
	{
		public DependencyInversion()
		{
			// SqlServer

			SqlServerDatabase sqlServer = new();

			SalesReport sqlServerMonthlyReport = new(sqlServer);

			sqlServerMonthlyReport.CreateReport(DateTime.Now.AddMonths(-1), DateTime.Now);
			sqlServerMonthlyReport.SaveReport();

			// Cassandra (Can also be a search engine)

			CassandraDatabase cassandra = new();

			SalesReport cassandraMonthlyReport = new(cassandra);

			cassandraMonthlyReport.CreateReport(DateTime.Now.AddMonths(-1), DateTime.Now);
			cassandraMonthlyReport.SaveReport();
		}
	}
}