using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace carvedrock.bl.principles.YAGNI
{
    public class Backpack
    {
        public string Name { get; } = null!;
        public double Price { get; }
        public int Capacity { get; }
        public double Weight { get; }
        public bool IsWaterproof { get; }
        public Backpack(string name, double price, int capacity, double weight, bool isWaterproof)
        {
            Name = name;
            Price = price;
            Capacity = capacity;
            Weight = weight;
            IsWaterproof = isWaterproof;
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public string ToXml()
        {
            throw new NotImplementedException();
        }
        public string ToCsv()
        {
            throw new NotImplementedException();
        }
        public string ToTsv()
        {
            throw new NotImplementedException();
        }
    }
}
