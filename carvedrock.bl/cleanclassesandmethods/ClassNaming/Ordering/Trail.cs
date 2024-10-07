
namespace carvedrock.bl.CleanClassesAndMethods.ClassNaming.Ordering
{
    public class Trail
    {
        public string RateTrail(decimal length, int elevation, string trailTraffic, string trailType)
        {
            if (length <= 0) throw new Exception("length cannot be null");
            if (elevation < 0) throw new Exception("elevation cannot be null");
            if (trailTraffic == null) throw new Exception("traffic cannot be null");
            if (trailType == null) throw new Exception("type cannot be null");

            if (length > 20 || elevation > 400) return "hard";
            else if ((length > 10) || (elevation > 100)) return (trailTraffic == "heavy") ? "hard" : "moderate";
            else return "easy";
        }
        public decimal Length { get; set; }
        public int Elevation { get; set; }
        public Trail(
            string Name,
            decimal Length,
            int Elevation,
            int Rating)
        {
            this.Name = Name;
            this.Length = Length;
            this.Elevation = Elevation;
            this.Rating = Rating;
        }
        public int Id { get; set; }

        public override string ToString()
        {
            return String.Format("Trail({0},{1},{2})", Name, Length, Rating);
        }

        public string? Name { get; set; }
        public int Rating { get; set; }
        
    }
}
