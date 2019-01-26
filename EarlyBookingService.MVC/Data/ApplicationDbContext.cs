using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.MVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    namespace EarlyBookingService.MVC.Data
    {
        public class ApplicationDbContext : IdentityDbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
        }
    }
}
