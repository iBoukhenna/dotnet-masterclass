
namespace carvedrock.bl.Conventions.NamingConventions.PublicMembers
{
    public class ClimbingShoes
    {
        // Public properties
        public string? name { get; set; }
        public bool instock;

        // An event
        public event Action? eventCheckInventory;

        // Method
        public void startCheckInventory()
        {
            // ...
        }
    }
}
