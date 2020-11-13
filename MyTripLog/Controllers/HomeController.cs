using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTripLog.Models;

namespace MyTripLog.Controllers
{
    public class HomeController : Controller
    {
        private TripContext Context;

        public HomeController(TripContext ctx)
        {
            Context = ctx;
        }

        public ViewResult Index()
        {
            // pass trips to view as model, converts into database / list
            TripListViewModel trip = new TripListViewModel();
            trip.TripList = Context.Trip.ToList();
            return View(trip);
        }
    }
}
