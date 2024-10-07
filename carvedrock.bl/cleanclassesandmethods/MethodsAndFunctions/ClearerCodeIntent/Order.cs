namespace carvedrock.bl.cleanclassesandmethods.MethodsAndFunctions.ClearerCodeIntent
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Items { get; set; } = null!;
        public double Total { get; set; }
        public int CustomerId { get; set; }


        public decimal TotalPriceOfSeasons(List<Product> listOfProducts, string seasonCategory)
        {
            return listOfProducts.Where(product => product.Season.Equals(seasonCategory)).Sum(product => product.Price);
            
        }


    }


}