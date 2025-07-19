using Ambev.DeveloperEvaluation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

/// <summary>
///  Response model for listing users.
/// </summary>
public class ListUsersResult
{
    /// <summary>
    /// List of users returned by the query.
    /// </summary>
    public required List<User>? Users { get; set; }
}
