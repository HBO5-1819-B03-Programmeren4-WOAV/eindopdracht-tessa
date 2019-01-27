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
    public class PriceDetailRepository: MappingRepository<PriceDetail>
    {
        public PriceDetailRepository(EarlyBookingServiceContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<List<PriceDetail>> GetByPurchaseCostId(int id)
        {
            return await GetAll()
                .Include(t => t.Booking)
                .Where(t => t.PurchaseCostId == id)
                .ToListAsync();
        }
    }
}
