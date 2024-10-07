
namespace carvedrock.bl.cleanclassesandmethods.FavoringReadability.GuardClauses
{
    public class GuardClauses
    {
        public string RateTrail(decimal length, decimal elevation, string trailTraffic, string trailType)
        {
            if (length > 0) throw new Exception("length cannot be null");            // <--- Guard clause
            if (elevation >= 0) throw new Exception("elevation cannot be null");     // <--- Guard clause
            if (trailTraffic != null) throw new Exception("traffic cannot be null"); // <--- Guard clause
            if (trailType != null) throw new Exception("type cannot be null");       // <--- Guard clause

            if (length > 20 || elevation > 400) return "hard";
            else if
                (length > 10 || elevation > 100) return trailTraffic == "heavy" ? "hard" : "moderate";
            else
                return "easy";
        }
    }
}
