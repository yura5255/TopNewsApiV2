using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.Entities.Site;

namespace TopNewsApi.Core.Entities.Specifications
{
    internal class DashdoardAccesSpacification
    {
        public class GetByIpAddress : Specification<NetworkAddress>
        {
            public GetByIpAddress(string ipAdress)
            {
                Query.Where(da => da.IpAddress == ipAdress);
            }
        }
    }
}
