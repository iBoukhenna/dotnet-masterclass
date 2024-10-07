
namespace carvedrock.bl.refactoring.DealingWithGeneralization.ExtractInterface
{
    public class MokaEspressoMaker
    {
        private double _coffeeBeans;
        private double _water;

        public double CoffeeBeans { get => _coffeeBeans; set => _coffeeBeans = value; }
        public double Water { get => _water; set => _water = value; }

        public void AddCoffee()
        {
            // Add 0.50 pounds of Costa Rican Coffee
            CoffeeBeans += 0.50;
        }
        public void AddWater()
        {
            // Adds 500 mL of water
            Water += 0.5;
        }
        public void GetSomeCoffee()
        {
            Console.WriteLine("Making expresso coffee");
        }
        public void GetMachineDetails()
        {
            Console.WriteLine("Sharing machine details...");
        }
    }
}
