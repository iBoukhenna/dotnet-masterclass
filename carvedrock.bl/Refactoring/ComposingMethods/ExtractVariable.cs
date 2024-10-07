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
            double itemPrice = order.Price;
            int itemQuantity = order.Quantity;
            double basePrice = itemQuantity * itemPrice;
            double quantityDiscount = Math.Max(0, itemQuantity - 600) * itemPrice * 0.07;
            double shipping = Math.Min(basePrice * 0.3, 100);
            return basePrice - quantityDiscount + shipping;
        }

        public static bool IsTrailExtraordinary(Trail trail)
        {
            bool isTrailShort = trail.Length > 200;
            bool isTrailEasy = trail.Difficulty < 4;
            bool isTrailtooElevated = trail.Elevation > 100;
            bool hasManyActivities = trail.Activities!.Count() > 10;

            return isTrailShort && isTrailEasy && !isTrailtooElevated && hasManyActivities;
        }
    }
}
