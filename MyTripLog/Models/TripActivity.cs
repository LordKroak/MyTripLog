using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTripLog.Models
{
    public class TripActivity
    {
        public int TripID { get; set; } //pkey
        public Trip Trip { get; set; } //nav to destination

        public int ActivityID { get; set; } //pkey
        public Activity Activity { get; set; } //nav to Activities
    }
}
