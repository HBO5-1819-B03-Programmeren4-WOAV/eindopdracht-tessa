using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarlyBookingService.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using EarlyBookingService.WebAPI.Repositories.Base;
using AutoMapper;
using EarlyBookingService.Lib.Models;

namespace EarlyBookingService.WebAPI.Repositories
{
    public class PurchaseCostRepository: MappingRepository<PurchaseCost>
    {

        public PurchaseCostRepository(EarlyBookingServiceContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<List<PurchaseCost>> ListEBR()
        {
            //show all purchase cost of Early Booking type for Accomodation
            return await GetAll()
                //.Include(t => t.Accomodation)
                .Where(t => t.CostType == CostType.EBR)
                .ToListAsync();
        }

        public async Task<List<PurchaseCost>> ListEBRPerAcco(int Id)
        {
            //show all purchase cost of Early Booking type for Accomodation
            return await GetAll()
                .Where(t => t.CostType == CostType.EBR && t.AccomodationId == Id)
                .ToListAsync();
        }

        public override async Task<PurchaseCost> GetById(int id)
        {
            return await db.PurchaseCosts
                .Include(p => p.Accomodation)
                .FirstOrDefaultAsync(p => p.Id == id);
        }


    }
}
