using AutoMapper;
using EarlyBookingService.Lib.Models;
using EarlyBookingService.WebAPI.Models;
using EarlyBookingService.WebAPI.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.WebAPI.Repositories
{
    public class BookingRepository: MappingRepository<Booking>
    {
        public BookingRepository(EarlyBookingServiceContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<List<Booking>> ListBookingForAcco(int Id)
        {
            return await GetAll()
                .Where(t => t.AccomodationId == Id)
                .ToListAsync();
        }
    }
}
