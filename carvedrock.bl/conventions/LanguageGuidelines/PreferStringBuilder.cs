using System.Diagnostics;

namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    public class PreferStringBuilder
    {
        public PreferStringBuilder()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string manySymbols = "";
            for (var i = 0; i < 1000; i++)
            {
                manySymbols += i.ToString() + ", ";
            }

            stopwatch.Stop();
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
        }
    }
}