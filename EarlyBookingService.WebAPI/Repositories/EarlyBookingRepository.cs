using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarlyBookingService.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<PurchaseCost> Update(PurchaseCost purchaseCost)
        {
            try
            {
                db.Entry(purchaseCost).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(!PurchaseCostExists(purchaseCost.Id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return purchaseCost;
        }

        public bool PurchaseCostExists(int id)
        {
            return db.PurchaseCosts.Any(e => e.Id == id);
        }
    }
}
