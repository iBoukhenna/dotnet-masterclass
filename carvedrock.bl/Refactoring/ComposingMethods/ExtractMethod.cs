namespace carvedrock.bl.refactoring.ComposingMethods
{
    public class ExtractMethod
    {
        public ExtractMethod()
        {
            int a = 1;
            int b = 2;
            int c = ((a - (b / 2)) ^ a) / b;
            int d = ((b - (c / 2)) ^ b) / c;
            int f = ((c - (d / 2)) ^ c) / d;
            Console.WriteLine(f);

            // 1. Select code
            // 2. Quick actions and Refactorings
            // 3. Extract method
        }
    }
}
