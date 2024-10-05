namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    public class FuncAndAction
    {
        // Actions 
        public static Action<string> Action1 = x => Console.WriteLine($"x is: {x}");

        public static Action<string, string> Action2 = (x, y) =>
            Console.WriteLine($"x is: {x}, y is {y}");

        // Func
        public static Func<string, int> Func1 = x => int.Parse(x);

        public static Func<int, int, int> Func2 = (x, y) => x * y;

        // Delegates

        public delegate void Del(string message);

        public static void DelMethod(string str)
        {
            Console.WriteLine("DelMethod argument: {0}", str);
        }

        public FuncAndAction()
        {
            Action1("string for x");
            Action2("string for x", "string for y");
            Console.WriteLine($"The value is {Func1("1")}");
            Console.WriteLine($"The sum is {Func2(1, 2)}");

            Del exampleDel2 = DelMethod;
            exampleDel2("Hey");

            // Full syntax

            Del exampleDel1 = new Del(DelMethod);
            exampleDel1("Hey");
        }
    }

}