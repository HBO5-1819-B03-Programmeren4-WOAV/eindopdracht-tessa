﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.WebAPI.Models
{
    public class PriceDetail
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        public int PurchaseCostId { get; set; }
        public PurchaseCost PurchaseCost { get; set; }
        public double Cost { get; set; }
    }
}
