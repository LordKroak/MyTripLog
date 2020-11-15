using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTripLog.Models
{
    public class Destination
    {
        public int DestinationID { get; set; } //pkey
        [Required(ErrorMessage = "Please enter a destination.")]
        public string Name { get; set; } //destination
        public ICollection<Trip> Trips { get; set; } //nav to multiple trips
    }
}
