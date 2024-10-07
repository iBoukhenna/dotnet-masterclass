namespace carvedrock.bl.refactoring.SimplifyinMethodCalls.SplitMergeMethods.ParameterizeMethod
{
    public class ParameterizeMethod
    {
        void ApplyDiscount(double seasonDiscount)
        {
        Backpack backpack = new("Tor 85 Litre Rucksack", 79.99, 85, 200, true);
        /// code...
        double price = backpack.Price;
        // code... 
        double total = price * seasonDiscount;
        // code...
        }
    }
}