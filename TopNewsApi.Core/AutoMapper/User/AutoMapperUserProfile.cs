using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.User;
using TopNewsApi.Core.Entities.User;

namespace TopNewsApi.Core.AutoMapper.User
{
    public class AutoMapperUserProfile : Profile
    {
        public AutoMapperUserProfile()
        {
            CreateMap<UsersDto, AppUser>().ReverseMap();
            CreateMap<UpdateUserDto, AppUser>().ReverseMap();
            CreateMap<CreateUserDto, AppUser>().ForMember(dst => dst.UserName, act => act.MapFrom(src => src.Email));
            CreateMap<AppUser, CreateUserDto>();
            CreateMap<DeleteUserDto, AppUser>().ReverseMap();
            CreateMap<EditUserDto, AppUser>().ReverseMap();
        }
    }
}
