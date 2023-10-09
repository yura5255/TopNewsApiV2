using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.Post;

namespace TopNewsApi.Core.AutoMapper.Post
{
    public class AutoMapperPostProfile : Profile
    {
        public AutoMapperPostProfile()
        {
            CreateMap<Entities.Site.Post, PostDto>().ReverseMap();
        }
    }
}
