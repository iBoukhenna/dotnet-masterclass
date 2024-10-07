
namespace carvedrock.bl.CleanClassesAndMethods.Static
{
    public static class CheckoutFunctions
    {
        public static decimal CalculateTax(decimal total, string twoLetterStateCode)
        {
            var rate = twoLetterStateCode switch
            {
                // Oregon, Alaska, Montana
                "OR" or "AK" or "MT" => 0.0M,
                // North Dakota, Wisconsin, Maine, Virginia
                "ND" or "WI" or "ME" or "VA" => 00.05M,
                // California
                "CA" => 0.0825M,
                // Most US states
                _ => 0.06M,
            };
            return total * rate;
        }
    }
}
