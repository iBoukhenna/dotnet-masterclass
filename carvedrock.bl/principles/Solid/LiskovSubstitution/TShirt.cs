using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.Solid.LiskovSubstitution
{
    public class TShirt
    {
        private readonly string _name;
        private readonly double _price;
        private readonly string _fabric;
        private readonly List<string> _sizes;

        public TShirt(string name, double price, string fabric, List<string> sizes)
        {
            _name = name;
            _price = price;
            _fabric = fabric;
            _sizes = sizes;
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
            return $"{thisName}: Name: {_name}, Price: {_price}, Fabric: {_fabric}, Sizes: {string.Join(',',_sizes)}";
        }
        
    }
}
