using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyBookingService.Lib.DTOs
{
    public class BookingDetail
    {
        public int Id { get; set; }
        public string ReservationNumber { get; set; }
        public string BookingDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int NumberOfParticipants { get; set; }
        public double TotalCost { get; set; }
    }
}
