
namespace carvedrock.bl.refactoring.DealingWithGeneralization.ExtractSuperClass
{
    public class Ropes
    {
        private int id;
        private string? name;
        private int type;
        private string[]? color;
        private string[]? size;
        private string? composition;
        private decimal price;
        private int ropeSize;
        private decimal staticElongation;
        private decimal dynamicElongation;
        private decimal impactForce;
        private decimal factorFalls;

        public int Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public int Type { get => type; set => type = value; }
        public string[]? Color { get => color; set => color = value; }
        public string[]? Size { get => size; set => size = value; }
        public string? Composition { get => composition; set => composition = value; }
        public decimal Price { get => price; set => price = value; }
        public int RopeSize { get => ropeSize; set => ropeSize = value; }
        public decimal StaticElongation { get => staticElongation; set => staticElongation = value; }
        public decimal DynamicElongation { get => dynamicElongation; set => dynamicElongation = value; }
        public decimal ImpactForce { get => impactForce; set => impactForce = value; }
        public decimal FactorFalls { get => factorFalls; set => factorFalls = value; }
    }
}
