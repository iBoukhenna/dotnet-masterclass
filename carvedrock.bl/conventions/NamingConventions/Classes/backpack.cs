
namespace carvedrock.bl.Conventions.NamingConventions.Classes
{
    public class Backpack
    {
        public string Name { get; } = null!;
        public double Price { get; set; }
        public int Capacity { get; }
        public double Weight { get; }
        public bool IsWaterproof { get; }
    }
}
