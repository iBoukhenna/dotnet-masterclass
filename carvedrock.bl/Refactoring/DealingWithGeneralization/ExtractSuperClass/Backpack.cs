
namespace carvedrock.bl.refactoring.DealingWithGeneralization.ExtractSuperClass
{
    public class Backpack
    {
        private int id;
        private string? name;
        private int type;
        private string[]? color;
        private string[]? size;
        private string? composition;
        private decimal price;
        private decimal capacity;
        private decimal weight;
        private bool isWaterproof;

        public int Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public int Type { get => type; set => type = value; }
        public string[]? Color { get => color; set => color = value; }
        public string[]? Size { get => size; set => size = value; }
        public string? Composition { get => composition; set => composition = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal Capacity { get => capacity; set => capacity = value; }
        public decimal Weight { get => weight; set => weight = value; }
        public bool IsWaterproof { get => isWaterproof; set => isWaterproof = value; }
    }
}
