
namespace carvedrock.bl.refactoring.OrganizingData
{
    public class Encapsulation
    {
        private int capacity;

        public int Capacity 
        { 
            get { return capacity; } 
            set
            {
                if (value > 0 && value < 5)
                    capacity = value;
                else 
                    capacity = 1;
            }

            // 1. Select the variable
            // 2. Right Click
            // 3. Quick actions and Refactoring
            // 4. Encapsulate field: 'Capacity' and 'Use property'
        }
    }
}
