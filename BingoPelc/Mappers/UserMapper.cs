using AutoMapper;
using BingoPelc.Entities;
using BingoPelc.Models;

namespace BingoPelc.Mappers;

public class UserMapper: Profile
{
    public UserMapper()
    {
        CreateMap<User, UserInfoDto>()
            .ForMember(dto => dto.Email, opt => opt.MapFrom(u => u.Email))
            .ForMember(dto => dto.Nickname, opt => opt.MapFrom(u => u.Nickname));
    }
}