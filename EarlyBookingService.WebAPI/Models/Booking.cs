using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.WebAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public ICollection<Participant> Participants { get; set; }
        public Accomodation Hotel { get; set; }
        public ICollection<PriceDetail> PriceDetails { get; set; }
    }
}
