
namespace carvedrock.bl.refactoring.DealingWithGeneralization.ExtractSuperClass
{
    public class Shoes
    {
        private int id;
        private string? name;
        private int type;
        private string[]? color;
        private string[]? size;
        private string? composition;
        private decimal price;
        private bool isWarmth;
        private bool isChlorineResistant;

        public int Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public int Type { get => type; set => type = value; }
        public string[]? Color { get => color; set => color = value; }
        public string[]? Size { get => size; set => size = value; }
        public string? Composition { get => composition; set => composition = value; }
        public decimal Price { get => price; set => price = value; }
        public bool IsWarmth { get => isWarmth; set => isWarmth = value; }
        public bool IsChlorineResistant { get => isChlorineResistant; set => isChlorineResistant = value; }
    }
}
