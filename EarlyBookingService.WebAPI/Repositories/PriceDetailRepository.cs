using AutoMapper;
using EarlyBookingService.Lib.Models;
using EarlyBookingService.Lib.DTOs;
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
        
        public async Task<List<PriceDetailBasic>> GetBookingList(int id)
        {
            return await db.PriceDetails.Where(t => t.PurchaseCostId == id)
                .Select(c => new PriceDetailBasic
                {
                    Id = c.Id,
                    BookingId = c.Booking.Id,
                    BookingReservationNumber = c.Booking.ReservationNumber,
                    PurchaseCostId = c.PurchaseCost.Id,
                }
                ).ToListAsync();
        }

        public async Task<List<PriceDetail>> GetPriceDetailsOfBooking(int id)
        {
            return await GetAll()
                .Where(p => p.BookingId == id)
                .OrderBy(p => p.PurchaseCost.CostType)
                .ToListAsync();
        }
    }
}
