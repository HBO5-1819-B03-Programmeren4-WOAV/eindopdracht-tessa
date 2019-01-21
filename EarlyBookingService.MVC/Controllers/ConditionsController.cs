using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EarlyBookingService.MVC.Helper;
using EarlyBookingService.Lib.Models;
using EarlyBookingService.Lib.DTOs;

namespace EarlyBookingService.MVC.Controllers
{
    public class ConditionsController : Controller
    {
        string baseEburi = "https://localhost:44328/api/EarlyBookingConditions/";
        string baseBookingUri = "https://localhost:44328/api/Bookings/";
        public IActionResult Index()
        {
            string conditionsUri = $"{baseEburi}";
            return View(WebApiHelper.GetApiResult<List<ConditionDetail>>(conditionsUri));
        }

        public IActionResult Bookings(int Id)
        {
            string bookingsUri = $"{baseBookingUri}/{Id}";
            return View(WebApiHelper.GetApiResult<List<Booking>>(bookingsUri));
        }
    }
}