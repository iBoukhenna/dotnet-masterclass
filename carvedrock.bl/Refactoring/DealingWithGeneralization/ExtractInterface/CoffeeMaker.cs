
namespace carvedrock.bl.refactoring.DealingWithGeneralization.ExtractInterface
{
    public class CoffeeMaker : ICoffeeMachine
    {
        private int _coffeeBeans;
        private int _water;

        public int CoffeeBeans { get => _coffeeBeans; set => _coffeeBeans = value; }
        public int Water { get => _water; set => _water = value; }

        public void AddCoffee()
        {
            // Add 1 pound of Costa Rican coffee
            CoffeeBeans += 1;
        }
        public void AddWater()
        {
            // Adds 1 L of water
            Water++;
        }
        public void GetSomeCoffee()
        {
            Console.WriteLine("Making hot coffee...");
        }
        public void GetMachineDetails()
        {
            Console.WriteLine("Sharing machine details...");
        }
    }
}
