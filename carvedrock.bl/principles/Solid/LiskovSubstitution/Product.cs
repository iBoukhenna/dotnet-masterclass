using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.LiskovSubstitution
{
    public abstract class Product
    {
        public abstract string GetName();
        public abstract double GetPrice();
        public abstract string GetDescription();
    }
}
