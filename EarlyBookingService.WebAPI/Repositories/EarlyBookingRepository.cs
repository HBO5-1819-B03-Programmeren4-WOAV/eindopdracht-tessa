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

        public List<PurchaseCost> ListEBR()
        {
            return db.PurchaseCosts.Where(t => t.CostType == CostType.EBR).ToList();
        }

    }
}
