using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EarlyBookingService.Lib.DTOs;
using EarlyBookingService.Lib.Models;

namespace EarlyBookingService.WebAPI.Services.AutoMapper
{
    public class AutoMapperProfileConfiguration: Profile
    {
        public AutoMapperProfileConfiguration() : this("MyProfile")
        {
        }

        protected AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {
           
        }
    }
}
