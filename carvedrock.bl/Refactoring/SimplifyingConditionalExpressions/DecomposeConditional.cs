namespace carvedrock.bl.refactoring.SimplifyingConditionalExpressions
{
    public class Trail
    {
        public string Name { get; set; } = null!;
        public List<string> Atractions { get; set; } = new();
    }

    public class DecomposeConditional
    {
        const decimal basePrice = 10;
        
        public decimal EstimateTrailFee(Trail trail)
        {
            if (IsHighSeason())
            {
                return EstimateHighSeasonFee(trail.Atractions.Count);
            }
            else
            {
                return EstimateLowSeasonFee(trail.Atractions.Count);
            }
        }

        private static bool IsHighSeason()
        {
            DateTime today = DateTime.Now;
            return (today.Month > 7) && (today.Month < 12);
        }

        private static decimal EstimateHighSeasonFee(int trailAtractions)
        {
            decimal HighSeasonRate = 1.5M;
            return (basePrice * HighSeasonRate) + (trailAtractions * 2);
        }

        private static decimal EstimateLowSeasonFee(int trailAtractions)
        {
            return basePrice + (trailAtractions * 0.5M);
        }
    }
}