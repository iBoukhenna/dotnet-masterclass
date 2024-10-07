namespace carvedrock.bl.refactoring.MovingFeaturesBetweenObjects.ExtractClass
{
    public class Trail
    {
        private int id;
        private string? name;
        private decimal length;
        private int elevation;
        private int rating;

        public int Id { get { return id; } set { id = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public decimal Length { get { return length; } set { length = value; } }
        public int Elevation { get { return elevation; } set { elevation = value; } }
        public int Rating { get { return rating; } set { rating = value; } }
        public TrailActivities TrailActivities { get; set; }
    }

}