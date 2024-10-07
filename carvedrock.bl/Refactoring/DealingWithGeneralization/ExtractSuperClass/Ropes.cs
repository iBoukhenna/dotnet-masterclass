namespace carvedrock.bl.refactoring.DealingWithGeneralization.ExtractSuperClass
{
    public class Ropes : Product
    {
        private int ropeSize;
        private decimal staticElongation;
        private decimal dynamicElongation;
        private decimal impactForce;
        private decimal factorFalls;

        public int RopeSize { get => ropeSize; set => ropeSize = value; }
        public decimal StaticElongation { get => staticElongation; set => staticElongation = value; }
        public decimal DynamicElongation { get => dynamicElongation; set => dynamicElongation = value; }
        public decimal ImpactForce { get => impactForce; set => impactForce = value; }
        public decimal FactorFalls { get => factorFalls; set => factorFalls = value; }
    }
}
