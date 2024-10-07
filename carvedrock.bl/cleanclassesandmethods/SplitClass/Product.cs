namespace carvedrock.bl.cleanclassesandmethods.SplitClass
{
    /// <summary>
    /// Product class contains the minimum features required by a product to be in the store.
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string[]? Color { get; set; }
        public string[]? Size { get; set; }
        public string? Composition { get; set; }
        public decimal Price { get; set; }
    }
}
