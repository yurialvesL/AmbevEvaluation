using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.ListUsers;

public class ListUsersRequestValidator : AbstractValidator<ListUsersRequest>
{
    private static readonly string[] AllowedFields = { "username", "email" };
    public ListUsersRequestValidator()
    {
        RuleFor(x => x.Page).GreaterThan(0).WithMessage("Page must be greater than 0.");
        RuleFor(x => x.Size).InclusiveBetween(1, 100).WithMessage("Size must be between 1 and 100.");

        When(x => !string.IsNullOrWhiteSpace(x.Order), () =>
        {
            RuleFor(x => x.Order)
                .Must(BeAValidOrdering)
                .WithMessage("Invalid _order format. Use fields like 'username asc, email desc'.");
        });
    }

    private bool BeAValidOrdering(string? order)
    {
        var fields = order!.Split(',');

        foreach (var f in fields)
        {
            var parts = f.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 0 || parts.Length > 2) return false;

            var field = parts[0].ToLower();
            var direction = parts.Length == 2 ? parts[1].ToLower() : "asc";

            if (!AllowedFields.Contains(field)) return false;
            if (direction != "asc" && direction != "desc") return false;
        }

        return true;
    }
}
