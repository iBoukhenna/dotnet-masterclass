namespace carvedrock.bl.CleanClassesAndMethods.DefiningClass
{
    public class Product
    {
        public int Id { get; set; }
        public bool InStock { get; set; }
        public string Supplier { get; set; } = string.Empty;

        public string? Name { get; set; }
        public string? Type { get; set; }
        public string[]? Color { get; set; } = { "Orange" };
        public string[]? Size { get; set; } = { "M" };
        public string? Composition { get; set; }
        public decimal Price { get; set; }
        public string? Season { get; set; }

        public Product(int id, bool inStock, string name, string type, string[] color, string[] size, string composition, decimal price, string season)
        {
            Id = id;
            InStock = inStock;
            Name = name;
            Type = type;
            Composition = composition;
            Price = price;
            Season = season;

        }
    }
}