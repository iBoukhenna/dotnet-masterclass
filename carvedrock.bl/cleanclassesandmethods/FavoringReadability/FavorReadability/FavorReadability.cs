
namespace carvedrock.bl.cleanclassesandmethods.FavoringReadability.FavorReadability
{
    public class FavorReadability
    {
        public string RateTrail(decimal length, decimal elevation, string trailTraffic, string trailType)
        {
            if (length < 0) throw new Exception("length cannot be null");
            if (elevation < 0) throw new Exception("elevation cannot be null");
            if (trailTraffic == null) throw new Exception("traffic cannot be null");
            if (trailType == null) throw new Exception("type cannot be null");

            if (length > 20 || elevation > 400) return "hard";
            else if
                (length > 10 || elevation > 100) return trailTraffic == "heavy" ? "hard" : "moderate";
            else
                return "easy";
        }
    }
}
