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
    public class AccomodationController : ControllerCrudBase<Accomodation, AccomodationRepository>
    {
        public AccomodationController(AccomodationRepository accoRepository) : base(accoRepository)
        {

        }
    }
}