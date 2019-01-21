﻿using System;
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

        // GET: api/T/2
        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int id)
        {
            return Ok(await repository.ListEBRPerAcco(id));
        }
    }
}