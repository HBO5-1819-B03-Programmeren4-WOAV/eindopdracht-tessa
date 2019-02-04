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
        
        public IActionResult Index(int Id)
        {
            return View();
        }

    }
}