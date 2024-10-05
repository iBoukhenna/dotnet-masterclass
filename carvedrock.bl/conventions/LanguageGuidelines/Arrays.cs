namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    public class Arrays
    {
        public Arrays()
        {
            // Concise syntax
            string[] japaneseVowels = { "a", "i", "u", "e", "o" };

            // Explicit instantiation
            var japaneseVowels2 = new string[] { "a", "i", "u", "e", "o" };

            // Initialize the elements one at time
            var ages = new int[2];
            ages[0] = 30;
            ages[1] = 25;
        }
    }
}