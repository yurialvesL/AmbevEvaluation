using Ambev.DeveloperEvaluation.Application.Users.ListUsers;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.ListUsers;

public class ListUsersProfile : Profile
{
    public ListUsersProfile()
    {
        CreateMap<ListUsersRequest, ListUsersCommand>()
            .ForMember(dest => dest.Page, opt => opt.MapFrom(src => src.Page))
            .ForMember(dest => dest.PageSize, opt => opt.MapFrom(src => src.Size))
            .ForMember(dest => dest.SearchTerm, opt => opt.MapFrom(src => src.Order));
    }
}
