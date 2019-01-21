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
        public String BookingStartDate { get; set; }
        public String BookingEndDate { get; set; }
        public String ReservationStartDate { get; set; }
        public String ReservationEndDate { get; set; }
        public Models.ValueType ValueType { get; set; }
        public double Amount { get; set; }
        public DateTime PrepaymentDate { get; set; }
        public int PrepaymentPercentage { get; set; }
        public Status Status { get; set; }
    }
}
