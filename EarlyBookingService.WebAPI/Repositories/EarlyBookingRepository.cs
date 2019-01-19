using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarlyBookingService.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EarlyBookingService.WebAPI.Repositories
{
    public class EarlyBookingRepository: Repository<PurchaseCost>
    {

        public EarlyBookingRepository(EarlyBookingServiceContext context) : base(context)
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
