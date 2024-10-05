using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.LiskovSubstitution
{
    public class Backpack
    {
        private readonly string _name;
        private readonly double _price;
        private readonly int _capacity;
        private readonly double _weight;

        public Backpack(string name, double price, int capacity, double weight)
        {
            _name = name;
            _price = price;
            _capacity = capacity;
            _weight = weight;
        }
        public string GetName()
        {
            return _name;
        }
        public double GetPrice()
        {
            return _price;
        }
        public string GetDescription()
        {
            string thisName = this.GetType().Name;
            return $"{thisName}: Name: {_name}, Price: {_price}, Capacity: {_capacity}, Weight: {_weight}";
        }
    }
}
