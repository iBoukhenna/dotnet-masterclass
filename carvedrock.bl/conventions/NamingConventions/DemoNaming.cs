namespace carvedrock.bl.Conventions.NamingConventions
{
    public class NamingConventions
    {
        // Class
         public class ClimbingShoes 
	    {
            // PascalCase
            // Public members
            public string name { get; } = null!;
            public double price { get; set; }
            public event Action eventCheckInventory = null!;

            // Multiple words
            public string countryoforigin = null!;

            // Positional record
            public record TrailAddress(string city, string state, string zipCode);
            

            // camelCase
            // Internal fields
            private int UniqueIdentifier;

            // Static internal fields
            private static int ReviewsQueue;

            [ThreadStatic]
            private static TimeSpan TimeSpan;

        }


        // Interfaces
        public interface Product
        {
            void priceWithDiscount();
        }


        // Method parameters
        public void SaveTrail(int TrailNumber, bool IsRegistered)
        {
            // Saved trail
        }


        // Additional Naming Conventions
        ClimbingShoes reallyLongVariableName = new carvedrock.bl.Conventions. NamingConventions.NamingConventions.ClimbingShoes();

    }
}