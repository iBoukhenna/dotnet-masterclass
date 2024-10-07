
namespace carvedrock.bl.refactoring.OrganizingData.ReplaceMagicNumber
{
    public class ReplaceMagicNumber
    {
        
        public int EstimateTrailDifficulty(double length, double elevation)
        {
            if ((length < 5) && (elevation < 500))
            {
                return 0;
            }
            else if ((length < 8) && (elevation < 1500))
            {
                return 1;
            }
            if ((length < 12) && (elevation < 3000))
            {
                return 2;
            }
            else
            {
                return -1;
            }
        }
    }
}
