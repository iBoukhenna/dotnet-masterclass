
namespace carvedrock.bl.refactoring.SimplifyingConditionalExpressions
{
    public class Product
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
    }

    public class ShoppingCart
    {
        public List<Product> Items { get; set; } = new();

        public decimal GetSubTotal()
        {
            decimal total = 0;
            foreach (Product product in Items)
            {
                total += product.Price;
            }
            return total;
        }
    }

    public class ConsolidateDuplicateConditional
    {
        public decimal GetTotalWithShipping (ShoppingCart cart, bool isSpecialCustomer, decimal shipping)
        {
            decimal total = cart.GetSubTotal();
            if (isSpecialCustomer)
            {
                total *= 0.70M;
            }
            else
            {
                total *= 0.99M;
            }
            total += shipping;
            return total;
        }
    }
}
