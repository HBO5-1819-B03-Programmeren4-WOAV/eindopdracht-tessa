using AutoMapper;
using EarlyBookingService.Lib.DTOs;
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

        public async Task<List<PriceDetail>> GetBookingWithEBR(int Id)
        {
            return await db.PriceDetails
                .Include(b => b.Booking)
                .Where(p => p.Id == Id)
                .ToListAsync();

            //to change to booking with a EB purchase cost
        }

        public async Task<BookingDetail> GetDetailById(int id)
        {
            return await db.Bookings
                .Select(c => new BookingDetail
                {
                    Id = c.Id,
                    BookingDate = c.BookingDate.ToString("dd/MM/yyyy"),
                    ReservationNumber = c.ReservationNumber,
                    StartDate = c.StartDate.ToString("dd/MM/yyyy"),
                    EndDate = c.EndDate.ToString("dd/MM/yyyy"),
                    NumberOfParticipants = c.Participants.Count(),
                    TotalCost = 0
                }).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
