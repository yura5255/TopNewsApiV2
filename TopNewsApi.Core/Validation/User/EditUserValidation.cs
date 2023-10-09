using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.User;

namespace TopNewsApi.Core.Validation.User
{
    public class EditUserValidation : AbstractValidator<EditUserDto>
    {
        public EditUserValidation()
        {
            RuleFor(r => r.Email).NotEmpty().EmailAddress();
            RuleFor(r => r.Role).NotEmpty();
            RuleFor(r => r.PhoneNumber).NotEmpty();
            RuleFor(r => r.FirstName).NotEmpty();
            RuleFor(r => r.LastName).NotEmpty();
        }
    }
}
