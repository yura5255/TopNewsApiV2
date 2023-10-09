using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.Category;
using TopNewsApi.Core.DTOs.Ip;
using TopNewsApi.Core.Entities;
using TopNewsApi.Core.Services;

namespace TopNewsApi.Core.Interfaces
{
    public interface INetworkAddressService
    {
        Task<List<NetworkAddressDto>> GetAll();
        Task Create(NetworkAddressDto model);
        Task Update(NetworkAddressDto model);
        Task Delete(int id);
        Task<NetworkAddressDto?> Get(string IpAddress);
        Task<NetworkAddressDto?> Get(int id);
    }
}
