using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.InterfaceSegregation
{
    public interface IExpressoMachine : ICoffeeMachine
    {
        public void GetExpressoCoffee();
    }
}
