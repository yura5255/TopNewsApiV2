using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.Category;
using TopNewsApi.Core.DTOs.Ip;
using TopNewsApi.Core.Entities;
using TopNewsApi.Core.Entities.Specifications;
using TopNewsApi.Core.Interfaces;

namespace TopNewsApi.Core.Services
{
    internal class NetworkAddressService : INetworkAddressService
    {
        private readonly IRepository<NetworkAddress> _ipRepo;
        private readonly IMapper _mapper;
        public NetworkAddressService(IRepository<NetworkAddress> ipRepo, IMapper mapper)
        {
            _ipRepo = ipRepo;
            _mapper = mapper;
        }

        public async Task Create(NetworkAddressDto model)
        {
            await _ipRepo.Insert(_mapper.Map<NetworkAddress>(model));
            await _ipRepo.Save();
        }

        public async Task Update(NetworkAddressDto model)
        {
            await _ipRepo.Update(_mapper.Map<NetworkAddress>(model));
            await _ipRepo.Save();
        }

        public async Task Delete(int id)
        {
            await _ipRepo.Delete(id);
            await _ipRepo.Save();
        }

        public async Task<NetworkAddressDto?> Get(string IpAddress)
        {
            return _mapper.Map<NetworkAddressDto>(await _ipRepo.GetItemBySpec(new DashdoardAccesSpacification.GetByIpAddress(IpAddress)));
        }

        public async Task<NetworkAddressDto?> Get(int id)
        {
            return _mapper.Map<NetworkAddressDto>(await _ipRepo.GetByID(id));
        }

        public async Task<List<NetworkAddressDto>> GetAll()
        {
            return _mapper.Map<List<NetworkAddressDto>>(await _ipRepo.GetAll());
        }
    }
}
