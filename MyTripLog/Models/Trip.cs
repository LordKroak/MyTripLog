using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTripLog.Models
{
    public class Trip
    {
        public int TripID { get; set; }
        [Required(ErrorMessage = "Please enter a destination.")]
        public string Destination { get; set; } 
        [Required(ErrorMessage = "Please enter the start date of your trip.")]
        public DateTime? StartDate { get; set; }
        [Required(ErrorMessage = "Please enter the end date of your trip.")]
        public DateTime? EndDate { get; set; }
        public string AccName { get; set; }
        public string AccPhone { get; set; }
        public string AccEmail { get; set; }
        public string Activity1 { get; set; }
        public string Activity2 { get; set; }
        public string Activity3 { get; set; }
    }
}
