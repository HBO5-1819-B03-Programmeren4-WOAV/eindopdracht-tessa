using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarlyBookingService.WebAPI.Models;

namespace EarlyBookingService.WebAPI.Repositories
{
    public class EarlyBookingRepository
    {
        private EarlyBookingServiceContext db;

        public EarlyBookingRepository(EarlyBookingServiceContext context)
        {
            db = context;
        }

        public List<PurchaseCost> ListEBR()
        {
            return db.PurchaseCosts.Where(t => t.CostType == CostType.EBR).ToList();
        }
    }
}
