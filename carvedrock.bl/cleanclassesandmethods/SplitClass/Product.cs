namespace carvedrock.bl.CleanClassesAndMethods.SplitClass
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

        #region shoes
        public bool Warmth { get; set; }
        public bool ChlorineResistant { get; set; }
        #endregion

        #region backpacks
        public decimal Capacity { get; set; }
        public decimal Weight { get; set; }
        public bool Waterproof { get; set; }
        #endregion

        #region ropes
        public int SizeInt { get; set; }
        public decimal Static { get; set; }
        public decimal Dynamic { get; set; }
        public decimal kN { get; set; }
        public decimal Falls { get; set; }
        #endregion

        #region kayaks
        public int Capacity2 { get; set; }
        public decimal Capacity3 { get; set; }
        #endregion

        #region apparels
        public bool WaterRepellent { get; set; }
        public string? Fabric { get; set; }
        public decimal Temperature { get; set; }
        #endregion
    }
}
