namespace carvedrock.bl.refactoring.DealingWithGeneralization.ExtractSuperClass
{
    public class Backpack : Product
    {
        private decimal capacity;
        private decimal weight;
        private bool isWaterproof;

        public decimal Capacity { get => capacity; set => capacity = value; }
        public decimal Weight { get => weight; set => weight = value; }
        public bool IsWaterproof { get => isWaterproof; set => isWaterproof = value; }
    }
}
