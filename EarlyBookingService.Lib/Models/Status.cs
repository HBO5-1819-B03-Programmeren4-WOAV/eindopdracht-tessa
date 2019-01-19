using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.Lib.Models
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
