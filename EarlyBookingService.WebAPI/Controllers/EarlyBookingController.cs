using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EarlyBookingService.WebAPI.Models;
using EarlyBookingService.WebAPI.Repositories;

namespace EarlyBookingService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EarlyBookingController : ControllerBase
    {
        EarlyBookingRepository repository;

        public EarlyBookingController(EarlyBookingRepository ebRepository)
        {
            repository = ebRepository;
        }

        // GET : api/Book
        [HttpGet]
        public IActionResult GetEBConditions()
        {
            return Ok(repository.ListEBR());
        }
    }
}