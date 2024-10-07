
namespace carvedrock.bl.refactoring.OrganizingData.ChangeTypeField
{
    public class Product
    {
        public string ProductType { get; set; } = null!;
        public string GetDescription()
        {
            if (ProductType == "Backpack")
            {
                // ...
                return "backpack-bp8493";
            }
            else if (ProductType == "Ropes")
            {
                // ...
                return "ropes-ro-3942";
            }
            else if (ProductType == "Shoes")
            {
                // ...
                return "shoes-sh2039";
            }
            else
            {
                return "not-found";
            }
        }
    }
}
