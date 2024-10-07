namespace carvedrock.bl.refactoring.SimplifyinMethodCalls.PreserveWholeObject
{
    public class PreserveWholeObject
    {
        public PreserveWholeObject()
        {
     
            Trail trail = new("Arizona Trail", 100000m, 2000, 5);

            SearchSimilarTrail(trail);
        }


        public void SearchSimilarTrail(Trail trail)
        {
            TrailExtras trailExtras = trail.Extras;
            TrailActivity trailActivities = trail.Activities;

            // Search for similar trails using extras and activities
        }

    }
}
