using AutoMapper;
using EarlyBookingService.Lib.Models;
using EarlyBookingService.WebAPI.Models;
using EarlyBookingService.WebAPI.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.WebAPI.Repositories
{
    public class ParticipantRepository: MappingRepository<Participant>
    {
        public ParticipantRepository(EarlyBookingServiceContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<List<Participant>> GetParticipantsFromBookingId(int id)
        {
            return await GetAll()
                .Where(t => t.BookingId == id)
                .ToListAsync();
        }
    }
}
