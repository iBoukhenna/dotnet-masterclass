
namespace carvedrock.bl.tests
{
    public class Trail
    {
        public string? Name { get; set; }
        public Difficulty Difficulty { get; set; }
        public double DistanceInMiles { get; set; }
        public double ElevationInFeet { get; set; }
        public int Rating { get; set; }
        public List<TrailActivity> Activities { get; set; } = new();

        public double EstimateTime()
        {
            if (DistanceInMiles <= 0)
                throw new Exception("Distance should be greater than 0");
            return DistanceInMiles / 3 + Math.Abs(ElevationInFeet / 2000);
        }
    }
}
