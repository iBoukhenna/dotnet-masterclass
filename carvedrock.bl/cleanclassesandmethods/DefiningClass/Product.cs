namespace carvedrock.bl.cleanclassesandmethods.DefiningClass
{
    public class Product
    {
        private readonly int id;
        private readonly bool inStock;
        private readonly string? supplier = string.Empty;

        private string? name;
        private string? type;
        private string[]? color = { "Orange" };
        private string[]? size = { "M" };
        private string? composition;
        private decimal price;
        private string? season;

        public string? Name { get { return name; } set { name = value; } }
        public string? Type { get { return type; } set { type = value; } }
        public string[]? Color { get { return color; } set { color = value; } }
        public string[]? Size { get { return size; } set { size = value; } }
        public string? Composition { get { return composition; } set { composition = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public string? Season { get { return season; } set { season = value; } }


        public Product(string name, string type, string[] color, string[] size, string composition, decimal price, string season)
        {
            Name = name;
            Type = type;
            Color = color;
            Size = size;
            Composition = composition;
            Price = price;
            Season = season;

        }
    }
}