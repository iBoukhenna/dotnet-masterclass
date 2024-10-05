namespace carvedrock.bl.Conventions.NamingConventions
{
    public class NamingConventions
    {

        // Class
         public class ClimbingShoes 
	    {
            // PascalCase
            // Public members
            public string Name { get; } = null!;
            public double Price { get; set; }
            public event Action EventCheckInventory = null!;

            // Multiple words
            public string CountryOfOrigin = null!;

            // Positional record
            public record TrailAddress(string City, string State, string ZipCode);
            

            // camelCase
            // Internal fields
            private int _uniqueIdentifier;

            // Static internal fields
            private static int s_reviewsQueue;

            [ThreadStatic]
            private static TimeSpan t_timeSpan;

        }


        // Interfaces
        public interface IProduct
        {
            void PriceWithDiscount();
        }


        // Method parameters
        public void SaveTrail(int trailNumber, bool isRegistered)
        {
            // Saved trail
        }


        // Additional naming conventions
        ClimbingShoes reallyLongVariableName = new carvedrock.bl.Conventions.
            NamingConventions.NamingConventions.ClimbingShoes();


    }
}