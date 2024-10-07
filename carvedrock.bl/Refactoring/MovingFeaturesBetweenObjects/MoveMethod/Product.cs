
namespace carvedrock.bl.refactoring.MovingFeaturesBetweenObjects.MoveMethod
{
    public class Product
    {
        public void AddToCart(ShoppingCart cart, int amount)
        {
            cart.Items.Add((this, amount));
        }
    }
}
