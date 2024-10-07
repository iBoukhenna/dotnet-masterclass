
namespace carvedrock.bl.refactoring.MovingFeaturesBetweenObjects.MoveMethod
{
    public class ShoppingCart
    {
        private List<(Product, int)> items = new();


        public void AddToCart(Product product, int number)
        {
            items.Add((product, number));
        }

    }
}
