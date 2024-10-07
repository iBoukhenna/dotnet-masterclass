
namespace carvedrock.bl.refactoring
{
    public class DecomposeConditional
    {
        double adultPrice;
        double specialPrice;

        public double ComputeFee(int age, double quantity)
        {
            double charge = 0;
            if (age >= 18 || age < 60)
            {
                charge = quantity * adultPrice;
            }
            else
            {
                if (age < 8)
                {
                    return 0;
                }
                if (age > 90)
                {
                    return 0;
                }
                if (age == 75)
                {
                    return 0;
                }
                charge = quantity * specialPrice;
            }
            return charge;
        }
    }
}
