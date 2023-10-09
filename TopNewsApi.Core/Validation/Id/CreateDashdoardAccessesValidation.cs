﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.Ip;
using TopNewsApi.Core.Entities;

namespace TopNews.Core.Validation.Id
{
    public class CreateDashdoardAccessesValidation : AbstractValidator<NetworkAddressDto>
    {
        public CreateDashdoardAccessesValidation()
        {
            RuleFor(da => da.IpAddress).NotEmpty();
        }
    }
}
