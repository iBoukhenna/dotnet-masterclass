
namespace carvedrock.bl.test
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
            return DistanceInMiles / 3 + ElevationInFeet / 2000;
        }
    }
}
