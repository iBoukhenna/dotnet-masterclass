
namespace carvedrock.bl.Conventions.NamingConventions.MethodParameters
{
    public class Trail
    {
        public int TrailNumber { get; set; }

        public void SaveTrail(int TrailNumber, bool IsRegistered)
        {
            // Saved trail
            if (IsRegistered)
                this.TrailNumber = TrailNumber;

            Console.WriteLine(TrailNumber);
        }
    }
}
