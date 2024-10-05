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

        public Backpack() { } // Required for Xml Serialization

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public string ToXml()
        {
            /*
            XmlSerializer serializer = new (this.GetType());
            using StringWriter textWriter = new();
            serializer.Serialize(textWriter, this);
            return textWriter.ToString();
            */
            throw new NotImplementedException();
        }
        public string ToCsv(bool returnHeader = false)
        {
            /*
            string header = "Name,Price,Capacity,Weight,IsWaterproof\n";

            string values = $"\"{Name}\",{Price},{Capacity},{Weight},{(IsWaterproof ? 1 : 0)}\n";

            if (returnHeader)
                return header + values;
            return values;
            */
            throw new NotImplementedException();
        }

        public string ToTsv(bool returnHeader = false)
        {
            /*
            string header = "Name\tPrice\tCapacity\tWeight\tIsWaterproof\n";

            string values = $"\"{Name}\"\t{Price}\t{Capacity}\t{Weight}\t{(IsWaterproof ? 1 : 0)}\n";

            if (returnHeader)
                return header + values;
            return values;
            */
            throw new NotImplementedException();
        }
    }
}
