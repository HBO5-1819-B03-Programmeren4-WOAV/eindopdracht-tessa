using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.Lib.Models
{
    public class Booking: EntityBase
    {
        public string ReservationNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Participant> Participants { get; set; }
        public int AccomodationId { get; set; }
        public Accomodation Accomodation { get; set; }

        [JsonIgnore]
        public ICollection<PriceDetail> PriceDetails { get; set; }
    }
}
