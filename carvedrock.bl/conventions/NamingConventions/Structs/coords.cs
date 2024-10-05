using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.NamingConventions.Structs
{
    public struct coords
    {
        public double lat;
        public double lon;
        public override string ToString() => $"Coords({lat}, {lon})";
    }
}
