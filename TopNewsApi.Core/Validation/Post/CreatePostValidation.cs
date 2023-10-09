using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.Post;

namespace TopNews.Core.Validation.Post
{
    public class CreatePostValidation : AbstractValidator<PostDto>
    {
        public CreatePostValidation()
        {
            RuleFor(p => p.Title).NotEmpty().WithMessage("Title must not be empty");
            RuleFor(p => p.Description).NotEmpty().WithMessage("Description must not be empty");
            RuleFor(p => p.FullText).NotEmpty().WithMessage("Text must not be empty");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Category must not be empty");
        }
    }
}
