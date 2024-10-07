namespace carvedrock.bl.CleanClassesAndMethods.MethodsAndFunctions.ClearerCodeIntent
{
    public class Product
    {
        private int id { get; set; }
        private decimal price;
        private string? name;
        private string? sport;
        private Season season;

        public decimal Price { get { return price; } set { price = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public string? Sport { get { return sport; } set { sport = value; } }
        public Season Season { get { return season; } set { season = value; } }


    }
}
