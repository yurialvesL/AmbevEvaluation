using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

public class ListUsersProfile : Profile
{
     public ListUsersProfile()
    {
        CreateMap<List<User>, ListUsersResult>()
            .ForMember(dest => dest.Users, opt => opt.MapFrom(src => src));

    }
}
