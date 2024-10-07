
namespace carvedrock.bl.refactoring.DealingWithGeneralization.ExtractSuperClass
{
    public class Product
    {
        private int id;
        private string? name;
        private int type;
        private string[]? color;
        private string[]? size;
        private string? composition;
        private decimal price;

        public int Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public int Type { get => type; set => type = value; }
        public string[]? Color { get => color; set => color = value; }
        public string[]? Size { get => size; set => size = value; }
        public string? Composition { get => composition; set => composition = value; }
        public decimal Price { get => price; set => price = value; }

        public override string ToString()
        {
            return Type switch
            {
                0 => string.Format("Shoe {0}", Name),
                1 => string.Format("Backpack"),
                2 => string.Format("Rope"),
                3 => string.Format("Kayak"),
                4 => string.Format("Apparel"),
                _ => string.Format("Sport Product"),
            };
        }
    }
}
