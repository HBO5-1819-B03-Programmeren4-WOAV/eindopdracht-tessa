using System;
using System.Collections.Generic;
using System.Text;

namespace EarlyBookingService.Lib.DTOs
{
    public class PriceDetailBasic
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public string BookingReservationNumber { get; set; }
        public int PurchaseCostId { get; set; }
    }
}
