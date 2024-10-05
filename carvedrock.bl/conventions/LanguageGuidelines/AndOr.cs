
namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    public class AndOr
    {
        public bool SecondOperand()
        {
            Console.WriteLine("Second Operand is evaluated");
            return true;
        }

        public AndOr()
        {
            var Price = 29;
            if ((Price % 7 == 0) & SecondOperand())
            {
                Price += 3;
            }
            Console.WriteLine($"Price: {Price}");
        }
    }
}