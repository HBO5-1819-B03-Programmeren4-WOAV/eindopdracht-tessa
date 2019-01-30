using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarlyBookingService.Lib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EarlyBookingService.WebAPI.Repositories;

namespace EarlyBookingService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantsController : ControllerCrudBase<Participant, ParticipantRepository>
    {
        public ParticipantsController(ParticipantRepository ebRepository): base(ebRepository)
        {

        }

        [HttpGet("{id}")]
        public override async Task<IActionResult> Get(int id)
        {
            return Ok(await repository.GetParticipantsFromBookingId(id));
        }
    }
}