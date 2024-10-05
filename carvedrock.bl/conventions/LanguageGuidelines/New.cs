namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    class ClimbingShoes
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<string> Color { get; set; } = new();
        public List<double> Size { get; set; } = new();

    }

    public class New
    {
        public New()
        {
            var climbingShoes = new ClimbingShoes()
            {
                Id = 2045,
                Name = "Hiking Shoes 3000",
                Color = new List<string> { "Black", "Blue", "Gray" },
                Size = new List<double> { 4.5, 5.0, 6.0, 6.5 }
            };

            ClimbingShoes climbingShoes1 = new() 
            {
                Id = 4582,
                Name = "Hiking/Running Shoes",
                Color = new List<string> { "White", "Red", "Green" },
                Size = new List<double> { 5.0, 5.5, 6.0 }
            };

        }
    }
}