namespace carvedrock.bl.Conventions.LanguageGuidelines
{
    public class StringInterpolation
    {
        public StringInterpolation()
        {
            var firstName = "Xavier";
            var lastName = "Morera";
            string displayName = firstName + " " + lastName;
            Console.WriteLine(displayName);
        }
    }
}