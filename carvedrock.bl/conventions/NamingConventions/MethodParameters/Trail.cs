
namespace carvedrock.bl.Conventions.NamingConventions.MethodParameters
{
    public class Trail
    {
        public int TrailNumber { get; set; }

        public void SaveTrail(int trailNumber, bool isRegistered)
        {
            // Saved trail
            if (isRegistered)
                TrailNumber = trailNumber;

            Console.WriteLine(trailNumber);
        }
    }
}
