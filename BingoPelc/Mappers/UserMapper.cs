using AutoMapper;
using BingoPelc.Entities;
using BingoPelc.Models;
using Microsoft.AspNetCore.Identity;

namespace BingoPelc.Mappers;

public class UserMapper: Profile
{
    public UserMapper()
    {
        CreateMap<User, UserInfoDto>()
            .ForMember(dto => dto.Email, opt => opt.MapFrom(u => u.Email))
            .ForMember(dto => dto.Nickname, opt => opt.MapFrom(u => u.Nickname));

        CreateMap<RegisterUserWithPasswordDto, User>()
            .ForMember(u => u.Email, opt => opt.MapFrom(p => p.Email))
            .ForMember(u => u.Nickname, opt => opt.MapFrom(p => p.NickName));
    }
}