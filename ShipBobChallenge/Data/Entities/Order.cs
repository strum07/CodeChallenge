using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipBobChallenge.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string TrackingId { get; set; }

        //indicates which address this order is being sent : one to one mapping
        public Address Address { get; set; }

        //indicates which user this order belongs to : one to one mapping
        public User User { get; set; }
    }
}
