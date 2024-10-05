namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    public class ImplicitlyTypedVariable
    {
        public ImplicitlyTypedVariable()
        {
            var var1 = "This is clearly a string";
            var var2 = 24;

            string? productName = Console.ReadLine();

            foreach (char letter in productName!)
            {
                if (letter == 'h')
                    Console.Write("H");
                else
                    Console.Write(letter);
            }

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}: {1}, {2}", i, var1, var2);
            }
        }
    }
}
