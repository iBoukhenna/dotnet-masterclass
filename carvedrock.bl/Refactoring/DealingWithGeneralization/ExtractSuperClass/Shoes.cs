namespace carvedrock.bl.refactoring.DealingWithGeneralization.ExtractSuperClass
{
    public class Shoes : Product
    {
        private bool isWarmth;
        private bool isChlorineResistant;

        public bool IsWarmth { get => isWarmth; set => isWarmth = value; }
        public bool IsChlorineResistant { get => isChlorineResistant; set => isChlorineResistant = value; }
    }
}
