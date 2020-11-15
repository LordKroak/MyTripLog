using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTripLog.Models
{
    public class Trip
    {

        public int TripID { get; set; } // hold pkey

        public int DestinationID { get; set; } //pkey
        public Destination Destination { get; set; } //nav to destination

        public int? AccommodationID { get; set; } //pkey
        public Accommodation Accommodation { get; set; } //nav to acc
        
        [Required(ErrorMessage = "Please enter the start date of your trip.")]
        public DateTime? StartDate { get; set; }
        [Required(ErrorMessage = "Please enter the end date of your trip.")]
        public DateTime? EndDate { get; set; }

        public ICollection<TripActivity> TripActivities { get; set; } //nav to multiple activities
    }
}
