namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    class HardWork : IDisposable
    {
        public string? KindOfWork { get; set; }
        public void DoSomeWork()
        {
            Console.WriteLine($"Doing some work ({KindOfWork!})");
            throw new Exception("Hammer Required");
        }

        public void Dispose()
        {
            KindOfWork = null;
            Console.WriteLine("Closing Connections");
            Console.WriteLine("Cleaning Variables");
        }
    }

    public class ExceptionHandling
    {
        public ExceptionHandling()
        {
            using HardWork buildFence = new() { KindOfWork = "building a fence"};
            buildFence.DoSomeWork();
        }
    }

}