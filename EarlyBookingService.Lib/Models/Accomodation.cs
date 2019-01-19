using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.Lib.Models
{
    public class Accomodation: EntityBase
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public ICollection<PurchaseCost> PurchaseCosts { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
