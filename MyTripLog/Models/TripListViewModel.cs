using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyTripLog.Models
{
    public class TripListViewModel
    {
        public Trip Trip { get; set; }
        public List<Trip> TripList { get; set; }
        public int PageNum { get; set; }
    }
}
