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
            ClimbingShoes climbingShoes = new ClimbingShoes();
            climbingShoes.Name = "Hiking Shoes 3000";
            climbingShoes.Color = new List<string> { "Black", "Blue", "Gray" };
            climbingShoes.Size = new List<double> { 4.5, 5.0, 6.0, 6.5 };

            ClimbingShoes climbingShoes1 = new();
            climbingShoes.Name = "Hiking/Running Shoes";
            climbingShoes.Color = new List<string> { "White", "Red", "Green" };
            climbingShoes.Size = new List<double> { 5.0, 5.5, 6.0 };
        }
        
    }
}