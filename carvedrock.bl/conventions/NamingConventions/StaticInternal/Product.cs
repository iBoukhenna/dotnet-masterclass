
namespace carvedrock.bl.Conventions.NamingConventions.StaticInternal
{
    public class Product
    {
        private static int ReviewsQueue;

        [ThreadStatic]
        private static TimeSpan TimeSpan;

        public Product()
        {
            ReviewsQueue = 0;
            TimeSpan = TimeSpan.Zero;
        }

        public static void Update()
        {
            ReviewsQueue--;
            TimeSpan = new TimeSpan(1, 2, 3);
        }

        public static void Log()
        {
            var reviews = ReviewsQueue;
            var timespan = TimeSpan.ToString();
            Console.WriteLine($"{reviews}, {timespan}");
        }
    }
}
