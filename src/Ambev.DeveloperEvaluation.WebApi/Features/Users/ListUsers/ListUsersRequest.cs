namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.ListUsers;

public class ListUsersRequest {
    /// <summary>
    /// The page number for pagination
    /// </summary>
    public int Page { get; set; } = 1;

    /// <summary>
    /// The size of each page for pagination
    /// </summary>
    public int Size { get; set; } = 10;

    /// <summary>
    ///     
    /// The order in which to sort the results, e.g., "asc" or "desc"
    /// </summary>
    public string? Order { get; set; } = null;


}
