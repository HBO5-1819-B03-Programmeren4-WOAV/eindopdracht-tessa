using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarlyBookingService.Lib.Models;
using EarlyBookingService.WebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EarlyBookingService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerCrudBase<Booking, BookingRepository>
    {
        public BookingsController(BookingRepository bookingRepository) : base(bookingRepository)
        {

        }

        // GET : api/Bookings/id
        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int Id)
        {
            return Ok(await repository.GetBookingWithEBR(Id));
        }

        // GET : api/Bookings/Detail/id
        [HttpGet("Detail/{id}")]
        public async Task<IActionResult> GetDetail(int Id)
        {
            return Ok(await repository.GetDetailById(Id));
        }
        
    }
}