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
        private TripContext Context { get; set; }

        public TripController(TripContext ctx)
        {
            this.Context = ctx;
        }
        public RedirectToActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }
        public RedirectToActionResult Cancel()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ViewResult Add(string id)
        {
            TripListViewModel vm = new TripListViewModel();
            switch (id?.ToLower())
            {
                case "page2":
                    string acc = TempData[nameof(Trip.AccName)]?.ToString();
                    if (string.IsNullOrWhiteSpace(acc))
                    {
                        vm.PageNum = 3;
                        string destination = TempData.Peek(nameof(Trip.Destination)).ToString();

                        vm.Trip = new Trip { Destination = destination };
                        return View("Page3", vm);
                    }

                    vm.PageNum = 2;
                    vm.Trip = new Trip { AccName = acc };
                    TempData.Keep(nameof(Trip.AccName));
                    return View("Page2", vm);

                case "page3":
                    vm.PageNum = 3;
                    vm.Trip = new Trip { Destination = TempData.Peek(nameof(Trip.Destination)).ToString() };
                    return View("Page3", vm);

                case "page1":
                    vm.PageNum = 1;
                    return View("Page1", vm);
                default:
                    vm.PageNum = 1;
                    return View("Page1", vm);
            }

        }

        [HttpPost]
        public IActionResult Add(TripListViewModel vm)
        {
            switch (vm.PageNum)
            {
                case 1:
                    if (!ModelState.IsValid)
                    {
                        return View("Page1", vm);
                    }

                    TempData[nameof(Trip.Destination)] = vm.Trip.Destination;
                    TempData[nameof(Trip.AccName)] = vm.Trip.AccName;
                    TempData[nameof(Trip.StartDate)] = vm.Trip.StartDate;
                    TempData[nameof(Trip.EndDate)] = vm.Trip.EndDate;
                    return RedirectToAction("Add", new { id = "Page2" });

                case 2:
                    TempData[nameof(Trip.AccPhone)] = vm.Trip.AccPhone;
                    TempData[nameof(Trip.AccEmail)] = vm.Trip.AccEmail;
                    return RedirectToAction("Add", new { id = "Page3" });

                case 3:
                    vm.Trip.Destination = TempData[nameof(Trip.Destination)].ToString();
                    vm.Trip.AccName = TempData[nameof(Trip.AccName)]?.ToString();
                    vm.Trip.StartDate = (DateTime)TempData[nameof(Trip.StartDate)];
                    vm.Trip.EndDate = (DateTime)TempData[nameof(Trip.EndDate)];
                    vm.Trip.AccPhone = TempData[nameof(Trip.AccPhone)]?.ToString();
                    vm.Trip.AccEmail = TempData[nameof(Trip.AccEmail)]?.ToString();

                    Context.Trips.Add(vm.Trip);
                    Context.SaveChanges();

                    TempData["message"] = $"Trip to {vm.Trip.Destination} added.";
                    return RedirectToAction("Index", "Home"); 
                default:
                    return RedirectToAction("Index", "Home");
            }
        }
    }
}
