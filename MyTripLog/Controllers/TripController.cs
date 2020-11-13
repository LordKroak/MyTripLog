using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTripLog.Models;

namespace MyTripLog.Controllers
{
    public class TripController : Controller
    {
        //TODO add new trip
        public IActionResult Add(string id)
        {
            if (id == "Page2")
            {
                return View("Page2");
            }
            else if (id == "Page3")
            {
                return View("Page3");
            }
            else
            {
                return View("Page1");
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
