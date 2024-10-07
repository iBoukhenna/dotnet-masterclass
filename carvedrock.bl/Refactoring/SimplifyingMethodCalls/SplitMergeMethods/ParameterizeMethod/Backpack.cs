namespace carvedrock.bl.refactoring.SimplifyinMethodCalls.SplitMergeMethods.ParameterizeMethod
{

    public class Backpack
    {
        private string? name;
        private double price;
        private int capacity;
        private double weight;
        private bool isWaterproof;

        public string? Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
        public bool IsWaterproof { get { return isWaterproof; } set { isWaterproof = value; } }

        public Backpack(string name, double price, int capacity, double weight, bool isWaterproof)
        {
            Name = name;
            Price = price;
            Capacity = capacity;
            Weight = weight;
            IsWaterproof = isWaterproof;
        }
    }
}