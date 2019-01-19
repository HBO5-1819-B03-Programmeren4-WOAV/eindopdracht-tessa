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
    public class EarlyBookingConditionsController : ControllerBase
    {
        EarlyBookingRepository repository;

        public EarlyBookingConditionsController(EarlyBookingRepository ebRepository)
        {
            repository = ebRepository;
        }

        // GET : api/EarlyBookingConditions
        [HttpGet]
        public IActionResult GetEBConditions()
        {
            return Ok(repository.ListEBR());
        }

        // PUT : api/EarlyBookingConditions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEarlyBookingCondition([FromRoute] int id, [FromBody] PurchaseCost purchaseCost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != purchaseCost.Id)
            {
                return BadRequest();
            }

            PurchaseCost p = await repository.Update(purchaseCost);
            if(p == null)
            {
                return NotFound();
            }

            return Ok(p);

        }
    }
}