using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.Category;

namespace TopNews.Core.Validation.Category
{
    public class CreateCategoryValidation : AbstractValidator<CategoryDto>
    {
        public CreateCategoryValidation()
        {
            RuleFor(c => c.Name).NotEmpty().MinimumLength(2).WithMessage("Must be at least 2 characters");
        }
    }
}
