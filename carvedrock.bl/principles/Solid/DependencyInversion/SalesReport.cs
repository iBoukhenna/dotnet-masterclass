using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.DependencyInversion
{
    public class SalesReport
    {
        private SqlServerDatabase _database;

        public SalesReport(SqlServerDatabase database)
        {
            _database = database;
        }

        public void CreateReport(DateTime from, DateTime to)
        {
            // Create a very important report
        }

        public void SaveReport()
        {
            // Create a very important report
        }
    }
}
