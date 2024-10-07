
namespace carvedrock.bl.refactoring.OrganizingData.ReplaceMagicNumber
{
    public class ReplaceMagicNumber
    {
        const int SmallDistance = 5;
        const int MediumDistance = 8;
        const int LongDistance = 12;

        const int SoftElevation = 500;
        const int MediumElevation = 1500;
        const int StrongElevation = 3000;


        public Difficulty EstimateTrailDifficulty(double length, double elevation)
        {
            if ((length < SmallDistance) && (elevation < SoftElevation))
            {
                return Difficulty.Easy;
            }
            else if ((length < MediumDistance) && (elevation < MediumElevation))
            {
                return Difficulty.Moderate;
            }
            if ((length < LongDistance) && (elevation < StrongElevation))
            {
                return Difficulty.Hard;
            }
            else
            {
                return Difficulty.ExtremelyHard;
            }
        }
    }
}
