using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.InterfaceSegregation
{
    public interface ICoffeeMachine
    {
        public void AddCoffee();
        public void AddWater();
        public void GetColdCoffee();
        public void GetExpressoCoffee();
    }
}
