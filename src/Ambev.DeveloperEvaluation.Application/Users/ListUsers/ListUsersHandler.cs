using Ambev.DeveloperEvaluation.Application.Users.GetUser;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

public class ListUsersHandler : IRequestHandler<ListUsersCommand, ListUsersResult>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public ListUsersHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }


    public async Task<ListUsersResult> Handle(ListUsersCommand request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.ListUsers(request.PageSize, request.Page, cancellationToken);

        var usersResult = _mapper.Map<List<User>>(users);

        if (usersResult is not null && !string.IsNullOrEmpty(request.SearchTerm))
        {
            var queryableUsers = usersResult.AsQueryable();
            usersResult = queryableUsers.OrderBy(request.SearchTerm).ToList();
        }

        return new ListUsersResult
        {
            Users = usersResult
        };
    }

}