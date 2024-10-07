namespace carvedrock.bl.CleanClassesAndMethods.MethodsAndFunctions.ClearerCodeIntent
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Items { get; set; } = null!;
        public double Total { get; set; }
        public int CustomerId { get; set; }


        public decimal total_pricesOfwinter_products(List<Product> l)
        {
            decimal r = 0;
            for (var i = 0; i < l.Count; i++)
            {
                if (l[i].Season.Equals("Winter"))
                {
                    decimal temp = l[i].Price;
                    r = r + temp;
                }
            }
            return r;
        }


        public decimal total_pricesOfsummer_products(List<Product> l)
        {
            decimal r = 0;
            for (var i = 0; i < l.Count; i++)
            {
                if (l[i].Season.Equals("Summer"))
                {
                    decimal temp = l[i].Price;
                    r = r + temp;
                }
            }
            return r;
        }


        public decimal total_pricesOfspring_products(List<Product> l)
        {
            decimal r = 0;
            for (var i = 0; i < l.Count; i++)
            {

                if (l[i].Season.Equals("Spring "))
                {
                    decimal temp = l[i].Price;
                    r = r + temp;
                }
            }
            return r;
        }

    }


}