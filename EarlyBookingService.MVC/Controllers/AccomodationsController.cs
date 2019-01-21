using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarlyBookingService.Lib.Models;
using EarlyBookingService.MVC.Helper;
using Microsoft.AspNetCore.Mvc;

namespace EarlyBookingService.MVC.Controllers
{
    public class AccomodationsController : Controller
    {
        string baseUri = "https://localhost:44328/api/Accomodation/";
        public IActionResult Index()
        {
            string conditionsUri = $"{baseUri}";
            return View(WebApiHelper.GetApiResult<List<Accomodation>>(conditionsUri));
        }
    }
}