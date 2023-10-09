using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.Ip;
using TopNewsApi.Core.Entities;

namespace TopNewsApi.Core.AutoMapper.Ip
{
    internal class AutoMapperDashdoardAccessProfile : Profile
    {
        public AutoMapperDashdoardAccessProfile()
        {
            CreateMap<NetworkAddress, NetworkAddressDto>().ReverseMap();
        }
    }
}
