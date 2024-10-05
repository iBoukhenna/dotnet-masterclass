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
            Console.WriteLine("Closing Connections");
            Console.WriteLine("Cleaning Variables");
        }
    }


    public class ExceptionHandling
    {

        public ExceptionHandling()
        {
            HardWork buildFence = new();
            try
            {
                buildFence.DoSomeWork();
            }
            catch (Exception e)
            {
                ;   // NEVER DO THIS!
            }
            finally
            {
                if (buildFence != null)
                {
                    buildFence.Dispose();
                }
            }
        }

    }

}