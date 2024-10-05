using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.InterfaceSegregation
{
    public class ColdBrewCoffeeMaker : IColdCoffeeMachine
    {
        private int _coffeeBeans; 
        private int _water;

        public void AddCoffee()
        {
            // Add 1 pound of Costa Rican Coffee
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
    }
}
