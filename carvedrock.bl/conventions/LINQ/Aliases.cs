using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.Conventions.LINQ
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        // ...
    }

    public class Trail
    {
        public int Id { get; set; }
        public double Distance { get; set; }
        public string City { get; set; } = null!;
        // ...
    }

    public class Aliases
    {
        private readonly List<User> _users;
        private readonly List<Trail> _trails;

        public Aliases()
        {
            _users = new(); // Load users
            _trails = new(); // Load trails

            var communityTrails =
                from user in _users
                join trail in _trails on user.City equals trail.City
                select new { Id1 = user.Id, Id2 = trail.Id };
        }
    }
}
