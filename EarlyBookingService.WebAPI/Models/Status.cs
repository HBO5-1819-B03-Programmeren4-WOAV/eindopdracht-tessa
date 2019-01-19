using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.WebAPI.Models
{
    public enum Status
    {
        NotSent,
        SentWithoutPrices,
        Validated,
        SentWithPrices,
        Prepayment
    }
}
