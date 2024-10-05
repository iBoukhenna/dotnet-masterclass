
namespace carvedrock.bl.Conventions.NamingConventions.StaticInternal
{
    public class Product
    {
        private static int s_reviewsQueue;

        [ThreadStatic]
        private static TimeSpan t_timeSpan;

        public Product()
        {
            s_reviewsQueue = 0;
            t_timeSpan = TimeSpan.Zero;
        }

        public static void Update()
        {
            s_reviewsQueue--;
            t_timeSpan = new TimeSpan(1, 2, 3);
        }

        public static void Log()
        {
            var reviews = s_reviewsQueue;
            var timespan = t_timeSpan.ToString();
            Console.WriteLine($"{reviews}, {timespan}");
        }
    }
}
