using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EarlyBookingService.WebAPI.Models;
using EarlyBookingService.WebAPI.Repositories;
using EarlyBookingService.Lib.Models;

namespace EarlyBookingService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EarlyBookingConditionsController : ControllerCrudBase<PurchaseCost, EarlyBookingRepository>
    {

        public EarlyBookingConditionsController(EarlyBookingRepository ebRepository) : base(ebRepository)
        {
        }

        // GET : api/EarlyBookingConditions
        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            return Ok(await repository.ListDetail());
        }

    }
}