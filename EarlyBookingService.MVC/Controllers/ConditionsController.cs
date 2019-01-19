using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EarlyBookingService.MVC.Helper;
using EarlyBookingService.Lib.Models;

namespace EarlyBookingService.MVC.Controllers
{
    public class ConditionsController : Controller
    {
        string baseuri = "https://localhost:44328/api/EarlyBookingConditions/";
        public IActionResult Index()
        {
            string conditionsUri = $"{baseuri}";
            return View(WebApiHelper.GetApiResult<List<PurchaseCost>>(conditionsUri));
        }
    }
}