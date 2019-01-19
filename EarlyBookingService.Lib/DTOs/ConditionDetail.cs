using EarlyBookingService.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyBookingService.Lib.DTOs
{
    public class ConditionDetail
    {
        public int Id { get; set; }
        public int AccomodationId { get; set; }
        public string AccomodationName { get; set; }
        public string AccomodationCountry { get; set; }
        public DateTime BookingStartDate { get; set; }
        public DateTime BookingEndDate { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public Models.ValueType ValueType { get; set; }
        public double Amount { get; set; }
        public DateTime PrepaymentDate { get; set; }
        public int PrepaymentPercentage { get; set; }
        public Status Status { get; set; }
    }
}
