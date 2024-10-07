namespace carvedrock.bl.refactoring.SimplifyingMethodCalls.PreserveWholeObject
{
    public class PreserveWholeObject
    {
        public PreserveWholeObject()
        {
            Trail trail = new("Arizona Trail", 100000m, 2000, 5);

            TrailExtras trailExtras = trail.Extras;
            TrailActivity trailActivities = trail.Activities;
            
            SearchSimilarTrail(trailExtras, trailActivities);
        }


        public void SearchSimilarTrail(TrailExtras trailExtras, TrailActivity trailActivities)
        {
            // Search for similar trails using extras and activities
        }

    }
}
