using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipBobChallenge.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //indicates the number of orders each user has 1 to many relationship
        public ICollection<Order> Orders { get; set; }
    }
}
