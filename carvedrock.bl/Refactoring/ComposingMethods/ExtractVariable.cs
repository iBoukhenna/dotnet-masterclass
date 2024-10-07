namespace carvedrock.bl.refactoring.ComposingMethods
{
    public class Order
    {
        private double price;
        private int quantity;
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }

    public class Trail
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int Difficulty { get; set; }
        public decimal Length { get; set; }
        public int Elevation { get; set; }
        public int Rating { get; set; }
        public string[]? Activities { get; set; }
    }

    public class ExtractVariable
    {
        public static double TotalPrice(Order order)
        {
            return order.Quantity * order.Price - Math.Max(0, order.Quantity - 600) * order.Price * 0.07 + Math.Min(order.Quantity * order.Price * 0.3, 100);
        }

        public static bool IsTrailExtraordinary(Trail trail)
        {
            return (trail.Length > 200) && trail.Difficulty < 4 && (trail.Elevation > 100) && trail.Activities!.Count() > 10;
        }
    }
}
