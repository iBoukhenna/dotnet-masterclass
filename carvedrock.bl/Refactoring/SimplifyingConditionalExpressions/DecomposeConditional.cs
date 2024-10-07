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
            DateTime today = DateTime.Now;
            decimal fee = 0;
            decimal HighSeasonRate = 1.5M;

            if (today.Month > 7 && today.Month < 12)
            {
                fee = (basePrice * HighSeasonRate) + (trail.Atractions.Count() * 2);
            }
            else
            {

                fee = basePrice + (trail.Atractions.Count() * 0.5M);
            }
            return fee;
        }
    }
}