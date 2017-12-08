using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipBobChallenge.Data.Entities
{
    public class Address
    {
        //this address can be used by one or more user to send to the same recipient
        //so leaving this as it is


        public int Id { get; set; }
        public string RecipientName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

    }
}
