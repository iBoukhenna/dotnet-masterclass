using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.DependencyInversion
{
    public interface IDatabase
    {
        public void Connect();
        public void Insert();
        public void Update(int id);
        public void Delete();
        public object[] Select();
        public object Select(int id);
    }
}
