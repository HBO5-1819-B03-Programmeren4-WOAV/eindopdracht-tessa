using AutoMapper;
using EarlyBookingService.Lib.Models;
using EarlyBookingService.WebAPI.Models;
using EarlyBookingService.WebAPI.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.WebAPI.Repositories
{
    public class AccomodationRepository: MappingRepository<Accomodation>
    {
        public AccomodationRepository(EarlyBookingServiceContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
