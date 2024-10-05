using System;
using System.Text.Json;
using System.Xml.Serialization;

namespace carvedrock.bl.principles.YAGNI
{

    public class YAGNI
    {
        public static void Demo()
        {
            Backpack regularBackpack = new("Everyday Backpack", 10.99, 20, 5, false);

            Console.WriteLine("JSON");
            Console.WriteLine(regularBackpack.ToJson());

            Console.WriteLine("XML");
            Console.WriteLine(regularBackpack.ToXml());

            Console.WriteLine("CSV");
            Console.WriteLine(regularBackpack.ToCsv());

            Console.WriteLine("TSV");
            Console.WriteLine(regularBackpack.ToTsv());

        }
    }
}

