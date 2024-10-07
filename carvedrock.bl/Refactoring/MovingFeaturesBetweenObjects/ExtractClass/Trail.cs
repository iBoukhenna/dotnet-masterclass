namespace carvedrock.bl.refactoring.MovingFeaturesBetweenObjects.ExtractClass
{
    public class Trail
    {
        private int id;
        private string? name;
        private decimal length;
        private int elevation;
        private int rating;

        private bool hasHiking;
        private bool hasMountainBiking;
        private bool hasRunning;
        private bool hasRoadBiking;
        private bool hasBackpacking;
        private bool hasWalking;
        private bool hasCamping;
        private bool hasFishing;
        private bool hasHorsebackRiding;


        public int Id { get { return id; } set { id = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public decimal Length { get { return length; } set { length = value; } }
        public int Elevation { get { return elevation; } set { elevation = value; } }
        public int Rating { get { return rating; } set { rating = value; } }

        public bool HasHiking { get { return hasHiking; } set { hasHiking = value; } }
        public bool HasMountainBiking { get { return hasMountainBiking; } set { hasMountainBiking = value; } }
        public bool HasRunning { get { return hasRunning; } set { hasRunning = value; } }
        public bool HasRoadBiking { get { return hasRoadBiking; } set { hasRoadBiking = value; } }
        public bool HasBackpacking { get { return hasBackpacking; } set { hasBackpacking = value; } }
        public bool HasWalking { get { return hasWalking; } set { hasWalking = value; } }
        public bool HasCamping { get { return hasCamping; } set { hasCamping = value; } }
        public bool HasFishing { get { return hasFishing; } set { hasFishing = value; } }
        public bool HasHorsebackRiding { get { return hasHorsebackRiding; } set { hasHorsebackRiding = value; } }
    }

}