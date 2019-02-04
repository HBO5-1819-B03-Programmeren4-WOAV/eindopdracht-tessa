using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EarlyBookingService.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using EarlyBookingService.WebAPI.Repositories.Base;
using AutoMapper;
using EarlyBookingService.Lib.Models;
using EarlyBookingService.Lib.DTOs;

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

        public async Task<List<PurchaseCostDetail>> GetListDetails()
        {
            return await db.PurchaseCosts.Where(t => t.CostType == CostType.EBR)
                .Select(c => new PurchaseCostDetail
                {
                    Id = c.Id,
                    AccomodationId = c.Accomodation.Id,
                    AccomodationName = c.Accomodation.Name,
                    AccomodationCountry = c.Accomodation.Country,
                    BookingStartDate = c.BookingStartDate.ToString("dd/MM/yyyy"),
                    BookingEndDateString = c.BookingEndDate.ToString("dd/MM/yyyy"),
                    BookingEndDate = c.BookingEndDate,
                    ReservationEndDate = c.ReservationEndDate.ToString("dd/MM/yyyy"),
                    ReservationStartDate = c.ReservationStartDate.ToString("dd/MM/yyyy"),
                    ValueType = c.ValueType,
                    Amount = c.Amount,
                    PrepaymentDate = c.PrepaymentDate.ToString("dd/MM/yyyy"),
                    PrepaymentPercentage = c.PrepaymentPercentage,
                    Status = c.Status,
                }).ToListAsync();
        }

        public async Task<List<PurchaseCostDetail>> GetListDetailsByAcco(int id)
        {
            return await db.PurchaseCosts.Where(t => t.CostType == CostType.EBR && t.AccomodationId == id)
                .Select(c => new PurchaseCostDetail
                {
                    Id = c.Id,
                    AccomodationId = c.Accomodation.Id,
                    AccomodationName = c.Accomodation.Name,
                    AccomodationCountry = c.Accomodation.Country,
                    BookingStartDate = c.BookingStartDate.ToString("dd/MM/yyyy"),
                    BookingEndDateString = c.BookingEndDate.ToString("dd/MM/yyyy"),
                    BookingEndDate = c.BookingEndDate,
                    ReservationEndDate = c.ReservationEndDate.ToString("dd/MM/yyyy"),
                    ReservationStartDate = c.ReservationStartDate.ToString("dd/MM/yyyy"),
                    ValueType = c.ValueType,
                    Amount = c.Amount,
                    PrepaymentDate = c.PrepaymentDate.ToString("dd/MM/yyyy"),
                    PrepaymentPercentage = c.PrepaymentPercentage,
                    Status = c.Status,
                }).ToListAsync();
        }

    }
}
