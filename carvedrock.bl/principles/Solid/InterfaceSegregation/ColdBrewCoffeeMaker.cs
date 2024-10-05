using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.InterfaceSegregation
{
    public class ColdBrewCoffeeMaker : ICoffeeMachine
    {
        private int _coffeeBeans; 
        private int _water;

        public void AddCoffee()
        {
            // Add 1 pound of Costa Rican coffee
            _coffeeBeans += 1;
        }

        public void AddWater()
        {
            // Add 1 liter of water
            _water++;
        }

        public void GetColdCoffee()
        {
            Console.WriteLine("Making Cold Brew");
        }

        public void GetExpressoCoffee()
        {
            throw new NotImplementedException();
        }
    }
}
