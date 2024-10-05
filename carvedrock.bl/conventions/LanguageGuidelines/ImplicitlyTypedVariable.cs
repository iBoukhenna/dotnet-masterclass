namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    static class Sports
    {
        public static int Count() { return 24; }
    }

    public class ImplicitlyTypedVariable
    {
        public ImplicitlyTypedVariable()
        {
            var var1 = Convert.ToInt32(Console.ReadLine());
            var var2 = Sports.Count();

            var productName = Console.ReadLine();

            foreach (var x in productName!)
            {
                if (x == 'h')
                    Console.Write("H");
                else
                    Console.Write(x);
            }

            for (int i=0; i<10; i++)
            {
                Console.WriteLine("{0}: {1}, {2}", i, var1, var2);
            }
        }
    }
}