using AutoMapper;
using EarlyBookingService.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EarlyBookingService.WebAPI.Repositories.Base
{
    public class MappingRepository<T> : Repository<T> where T : EntityBase
    {
        protected readonly IMapper mapper;

        public MappingRepository(EarlyBookingServiceContext context, IMapper mapper) : base(context)
        {
            this.mapper = mapper;
        }
    }
}
