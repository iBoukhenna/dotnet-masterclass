namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
    }

    public class Static
    {
        public Static()
        {
            // 1
            ShoppingCart cart1 = new();
            cart1.AddItem(new Product() { Name = "Backpack" });

            foreach (var item in cart1.Items)
            {
                Console.WriteLine(item.Name);
            }

            // 2
            ShoppingCart cart2 = new();
            cart2.AddItem(new Product() { Name = "ClimbingShoes" });

            foreach (var item in cart2.Items)
            {
                Console.WriteLine(item.Name);
            }

            // 3
            ShoppingCart cart3 = new();
            cart3.EmptyItems();

            foreach (var item in cart3.Items)
            {
                Console.WriteLine(item.Name);
            }
        }

        public class ShoppingCart
        {
            public List<Product> Items = new();

            public void AddItem(Product product)
            {
                Items.Add(product);
            }

            public void EmptyItems()
            {
                Items.Clear();
            }

        }
    }
}