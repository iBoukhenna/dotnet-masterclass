
namespace carvedrock.bl.refactoring
{
    public class ExtractMethod
    {
        public ExtractMethod()
        {
            int a = 1;
            int b = 2;
            int c = ComplexEquation(a, b);
            int d = ComplexEquation(b, c);
            int f = ComplexEquation(c, d);
            Console.WriteLine(f);
        }

        private static int ComplexEquation(int a, int b)
        {
            return ((a - (b / 2)) ^ a) / b;
        }
    }
}
