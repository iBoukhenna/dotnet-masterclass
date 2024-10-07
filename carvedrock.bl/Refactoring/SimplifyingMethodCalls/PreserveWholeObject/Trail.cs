namespace carvedrock.bl.refactoring.SimplifyingMethodCalls.PreserveWholeObject
{
    public class Trail
    {
        private int id;
        private string? name;
        private decimal length;
        private int elevation;
        private int rating;
        private TrailActivity activities;
        private TrailExtras extras;

        public int Id { get { return id; } set { id = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public decimal Length { get { return length; } set { length = value; } }
        public int Elevation { get { return elevation; } set { elevation = value; } }
        public int Rating { get { return rating; } set { rating = value; } }
        public TrailActivity Activities { get { return activities; } set { activities = value; } }
        public TrailExtras Extras { get { return extras; } set { extras = value; } }

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
    }
}

