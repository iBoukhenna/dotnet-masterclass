
namespace carvedrock.bl.Conventions.NamingConventions.InternalFields
{
    public class ClimbingShoes
    {
        private readonly int _uniqueIdentifier;

        public ClimbingShoes()
        {
            _uniqueIdentifier = 0;

            var variableInsideConstructor = "";
            Console.WriteLine(variableInsideConstructor);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} (UniqueId={_uniqueIdentifier})";
        }
    }
}
