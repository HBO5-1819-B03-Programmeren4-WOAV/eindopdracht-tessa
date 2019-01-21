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

        public async Task<List<ConditionDetail>> ListDetail()
        {
            return await db.PurchaseCosts.Where(t => t.CostType == CostType.EBR)
                .Select(c => new ConditionDetail
            {
                Id = c.Id,
                AccomodationId = c.Accomodation.Id,
                AccomodationName = c.Accomodation.Name,
                AccomodationCountry = c.Accomodation.Country,
                BookingStartDate = c.BookingStartDate.ToString("dd/MM/yyyy"),
                BookingEndDate = c.BookingEndDate.ToString("dd/MM/yyyy"),
                ReservationEndDate = c.ReservationEndDate.ToString("dd/MM/yyyy"),
                ReservationStartDate = c.ReservationStartDate.ToString("dd/MM/yyyy"),
                ValueType = c.ValueType,
                Amount = c.Amount,
                PrepaymentDate = c.PrepaymentDate,
                PrepaymentPercentage = c.PrepaymentPercentage,
                Status = c.Status,
            }).ToListAsync();
        }


    }
}
