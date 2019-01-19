using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarlyBookingService.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using EarlyBookingService.WebAPI.Repositories.Base;
using AutoMapper;

namespace EarlyBookingService.WebAPI.Repositories
{
    public class EarlyBookingRepository: MappingRepository<PurchaseCost>
    {

        public EarlyBookingRepository(EarlyBookingServiceContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<List<PurchaseCost>> ListEBR()
        {
            return await GetAll()
                .Where(t => t.CostType == CostType.EBR)
                .ToListAsync();
        }

    }
}
