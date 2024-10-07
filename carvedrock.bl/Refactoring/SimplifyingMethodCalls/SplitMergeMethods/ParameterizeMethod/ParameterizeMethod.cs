namespace carvedrock.bl.refactoring.SimplifyinMethodCalls.SplitMergeMethods.ParameterizeMethod
{
    public class ParameterizeMethod
    {
        const double WINTER_DISCOUNT_CONSTANT = 0.30;
        const double SUMMER_DISCOUNT_CONSTANT = 0.25;
        void ApplyWinterDiscount()
        {
            Backpack backpack = new("Tor 85 Litre Rucksack", 79.99, 85, 200, true);
            /// code...
            double price = backpack.Price;
            // code...
            double total = price * WINTER_DISCOUNT_CONSTANT;
            // code...
        }

        void ApplySummerDiscount()
        {
            Backpack backpack = new("Tor 85 Litre Rucksack", 79.99, 85, 200, true);
            // code...
            double price = backpack.Price;
            // code... 
            double total = price * SUMMER_DISCOUNT_CONSTANT;
            // code...
        }

 
    }
}