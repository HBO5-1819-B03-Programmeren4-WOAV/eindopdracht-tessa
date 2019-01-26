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
    public class PurchaseCostController : ControllerCrudBase<PurchaseCost, PurchaseCostRepository>
    {

        public PurchaseCostController(PurchaseCostRepository ebRepository) : base(ebRepository)
        {
        }

        [HttpGet]
        public override async Task<IActionResult> Get()
        {
            return Ok(await repository.ListEBR());
        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int id)
        {
            return Ok(await repository.GetById(id));
        }
        
        // GET: api/T/2
        [HttpGet("Acco/{id}")]
        public async Task<IActionResult> GetByAcco(int id)
        {
            return Ok(await repository.ListEBRPerAcco(id));
        }

        // GET: api/PurchaseCost/Details
        [HttpGet]
        [Route("Details")]
        public async Task<IActionResult> GetPurchaseCostDetail()
        {
            return Ok(await repository.GetListDetails());
        }
    }
}