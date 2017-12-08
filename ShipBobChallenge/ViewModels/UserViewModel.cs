using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShipBobChallenge.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [MinLength(5)]
        public string FirstName { get; set; }


        [Required]
        [MinLength(1)]
        public string LastName { get; set; }
    }
}
