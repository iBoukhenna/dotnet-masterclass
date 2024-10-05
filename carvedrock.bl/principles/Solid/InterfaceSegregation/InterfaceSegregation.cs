namespace carvedrock.bl.principles.Solid.InterfaceSegregation
{
    public class InterfaceSegregation
    {
        public InterfaceSegregation()
        {

            ColdBrewCoffeeMaker ColdCoffeeMachine = new();
            MokaEspressoMaker MokaExpressoMachine = new();


            ColdCoffeeMachine.GetColdCoffee();
            ColdCoffeeMachine.GetExpressoCoffee(); // This fails

            MokaExpressoMachine.GetExpressoCoffee();
            MokaExpressoMachine.GetColdCoffee(); // This fails

        }
    }
}
