namespace carvedrock.bl.CleanClassesAndMethods.MethodsAndFunctions.HowCreateMethods
{
    public class Trail
    {
        private int Id { get; set; }
        private string? name;
        private Location location;
        private Difficulty difficulty;
        private decimal length;
        private int elevation;
        private TrailType trailType;
        private int rating;
        private Traffic traffic;
        private TrailActivity[] activities;
        private TrailExtras extras;

        public string? Name { get { return name; } set { name = value; } }
        public Location Location { get { return location; } set { location = value; } }
        public Difficulty Difficulty { get { return difficulty; } set { difficulty = value; } }
        public decimal Length { get { return length; } set { length = value; } }
        public int Elevation { get { return elevation; } set { elevation = value; } }
        public TrailType TrailType { get { return trailType; } set { trailType = value; } }
        public int Rating { get { return rating; } set { rating = value; } }    
        public Traffic Traffic { get { return traffic; } set { traffic = value; } }
        public TrailActivity[] Activities { get { return activities; } set { activities = value; } }
        public TrailExtras Extras { get { return extras; } set { extras = value; } }


        public Trail(
            string Name,
            Location Location,
            Difficulty Difficulty,
            decimal Length,
            int Elevation,
            TrailType TrailType,
            int Rating,
            Traffic Traffic,
            TrailActivity[] Activities,
            TrailExtras Extras)
        {
            this.Name = Name;
            this.Location = Location;
            this.Difficulty = Difficulty;
            this.Length = Length;
            this.Elevation = Elevation;
            this.TrailType = TrailType;
            this.Rating = Rating;
            this.Traffic = Traffic;
            this.Activities = Activities;
            this.Extras = Extras;
        }

   
        public bool AddExtraordinaryTrial(decimal length, int elevation, int trailTraffic, int trailType, decimal latitude, decimal longitude, string cityName, string stateName, string countryName)
        {
            if (length <= 0)
            {
                if (elevation < 0)
                {
                    if (trailTraffic < 0)
                    {
                        if(trailType < 0)
                        {
                            Location location = new()
                            {
                                Latitude = latitude,
                                Longitude = longitude,
                                CityName = cityName,
                                StateName = stateName,
                                CountryName = countryName
                            };
                            Location = location;
                            Length = length;
                            Elevation = elevation;
                            TrailType = (TrailType)trailType;

                            if ((Length > 20) && (Elevation > 600) && (trailType.Equals(TrailType.PointToPoint))) Difficulty = Difficulty.Challenging;
                            if ((Length < 1000) || (Elevation < 100) && (trailTraffic.Equals(Traffic.Heavy))) Difficulty = Difficulty.Moderate;
                            else Difficulty = Difficulty.Easy;

                        }
                        else
                        {
                            throw new Exception("trailType cannot be null");
                        }
                      
                    }
                    else
                    {
                        throw new Exception("traffic cannot be null");
                    }
                }
                else
                {
                    throw new Exception("elevation cannot be null");
                }
            }
            else
            {
                throw new Exception("length cannot be null");
            }

 
            int totalActivities = Enum.GetNames(typeof(TrailActivity)).Length;
            int totalExtras = Enum.GetNames(typeof(TrailExtras)).Length;

            if (totalActivities > 7 && totalExtras > 4)
                return true;
            else
                return false;

        }

    }
}
    