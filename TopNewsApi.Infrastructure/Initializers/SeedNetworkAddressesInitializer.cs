using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.Entities;

namespace TopNewsApi.Infrastructure.Initializers
{
    internal static class SeedNetworkAddressesInitializer
    {
        public static void SeedNetworkAddresses(this ModelBuilder model)
        {
            model.Entity<NetworkAddress>().HasData(
                new NetworkAddress()
                {
                    Id = 1,
                    IpAddress = "0.0.0.0",
                }
            );
        }
    }
}
