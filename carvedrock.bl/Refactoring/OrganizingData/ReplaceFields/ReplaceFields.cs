
namespace carvedrock.bl.refactoring.OrganizingData.ReplaceFields
{
    public class ReplaceFields
    {
        // Change `howHard` to `Difficulty` and create an enumeration.
        // Change `lat` and `lon` to `Latitude` and `Longitude`.
        // Create a struct called `Location` with the properties
        // `Latitude`, `Longitude`, `CityName`, `StateName`, `CountryName`

        private Difficulty difficulty;
        private Location location;

        public Difficulty Difficulty { get => difficulty; set => difficulty = value; }
        public Location Location { get => location; set => location = value; }
    }
}
