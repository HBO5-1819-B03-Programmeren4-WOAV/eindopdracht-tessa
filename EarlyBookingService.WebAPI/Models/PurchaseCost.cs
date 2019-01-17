using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.WebAPI.Models
{
    public class PurchaseCost
    {
        public int Id { get; set; }
        public int AcommodationId { get; set; }
        public Accomodation Accomodation { get; set; }
        public CostType CostType { get; set; }
        public DateTime BookingStartDate { get; set;}
        public DateTime BookingEndDate { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public ValueType ValueType { get; set; }
        public double Amount { get; set; }
        public DateTime PrepaymentDate { get; set; }
        public int PrepaymentPercentage { get; set; }
    }
}
