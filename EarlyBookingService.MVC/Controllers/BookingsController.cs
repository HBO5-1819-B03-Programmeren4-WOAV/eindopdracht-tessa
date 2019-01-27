using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarlyBookingService.Lib.DTOs;
using EarlyBookingService.Lib.Models;
using EarlyBookingService.MVC.Helper;
using Microsoft.AspNetCore.Mvc;

namespace EarlyBookingService.MVC.Controllers
{
    
    public class BookingsController : Controller
    {
        string baseUri = "https://localhost:44396/api/PriceDetails/";
        public IActionResult Index(int id)
        {
            string bookingsUri = $"{baseUri}/{id}";
            return View(WebApiHelper.GetApiResult<List<PriceDetailBasic>>(bookingsUri));
        }
    }
}