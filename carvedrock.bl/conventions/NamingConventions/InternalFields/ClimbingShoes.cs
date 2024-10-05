
namespace carvedrock.bl.Conventions.NamingConventions.InternalFields
{
    public class ClimbingShoes
    {
        public int name;

        private readonly int UniqueIdentifier;

        public ClimbingShoes()
        {
            UniqueIdentifier = 0;

            var Variable_Inside_Constructor = "";

            Console.WriteLine(Variable_Inside_Constructor);
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} (UniqueId={UniqueIdentifier})";
        }
    }
}
