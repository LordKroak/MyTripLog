using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTripLog.Models
{
    public class Activity
    {
        public int ActivityID { get; set; } //pkey
        public string Name { get; set; } //Name of activity
        public ICollection<Trip> Trips { get; set; } //nav to multiple trips
    }
}
