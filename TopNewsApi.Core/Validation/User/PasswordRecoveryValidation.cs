using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.User;

namespace TopNewsApi.Core.Validation.User
{
    public class PasswordRecoveryValidation : AbstractValidator<PasswordRecoveryDto>
    {
        public PasswordRecoveryValidation()
        {
            RuleFor(r => r.Email).NotEmpty().EmailAddress();
            RuleFor(r => r.Password).NotEmpty().MinimumLength(6).Equal(r => r.ConfirmPassword);
        }
    }
}
