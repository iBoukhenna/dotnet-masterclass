
namespace carvedrock.bl.refactoring.SimplifyinMethodCalls.IntroduceParameterObject
{
    public class Reports
    {
        public string Sales(DateTimePeriod period)
        {
            return $"Sales Report from {period.From:g} to {period.To:g}";
        }

        public string Expenses(DateTimePeriod period)
        {
            return $"Expenses Report from {period.From:g} to {period.To:g}";
        }

        public string ProductSales(DateTimePeriod period, Product product)
        {
            return $"Sales Report from {period.From:g} to {period.To:g} for {product.Name}";
        }
    }
}
