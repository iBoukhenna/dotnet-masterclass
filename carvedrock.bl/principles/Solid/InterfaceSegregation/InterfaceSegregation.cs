namespace carvedrock.bl.principles.Solid.InterfaceSegregation
{
    public class InterfaceSegregation
    {
        public InterfaceSegregation()
        {
            ColdBrewCoffeeMaker ColdCoffeeMachine = new();
            MokaEspressoMaker MokaExpressoMachine = new();


            ColdCoffeeMachine.GetColdCoffee();
            //ColdCoffeeMachine.GetExpressoCoffee(); // Now it is not allowed

            MokaExpressoMachine.GetExpressoCoffee();
            //MokaExpressoMachine.GetColdCoffee(); // Now it is not allowed
        }
    }
}
