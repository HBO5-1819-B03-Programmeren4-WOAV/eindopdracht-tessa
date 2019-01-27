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
    public class PriceDetailsController : ControllerCrudBase<PriceDetail, PriceDetailRepository>
    {
        public PriceDetailsController(PriceDetailRepository pdRepository) : base(pdRepository)
        {

        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int id)
        {
            return Ok(await repository.GetBookingList(id));
        }
    }
}