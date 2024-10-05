namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
    }

    public class StaticExample
    {

        public StaticExample()
        {
            ShoppingCart cart1 = new();
            // 1
            cart1.AddItem(new Product() { Name = "Backpack" });

            // 2
            cart1.AddItem(new Product() { Name = "ClimbingShoes" });

            // 3
            cart1.EmptyItems();

            foreach (var item in cart1.Items)
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