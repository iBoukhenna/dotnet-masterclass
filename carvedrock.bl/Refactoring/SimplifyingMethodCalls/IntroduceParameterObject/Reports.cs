
namespace carvedrock.bl.refactoring.SimplifyinMethodCalls.IntroduceParameterObject
{
    public class Reports
    {
        public string Sales(DateTime from, DateTime to)
        {
            return $"Sales Report from {from:g} to {to:g}";
        }

        public string Expenses(DateTime from, DateTime to)
        {
            return $"Expenses Report from {from:g} to {to:g}";
        }

        public string ProductSales(DateTime from, DateTime to, Product product)
        {
            return $"Sales Report from {from:g} to {to:g} for {product.Name}";
        }
    }
}
