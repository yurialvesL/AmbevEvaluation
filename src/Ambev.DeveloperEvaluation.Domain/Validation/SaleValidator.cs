using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Validation;

public class SaleValidator: AbstractValidator<Sale>
{
    public SaleValidator()
    {
        RuleFor(x => x.SaleNumber)
            .NotEmpty().WithMessage("SaleNumber is required");

        RuleFor(x => x.Branch)
            .NotEmpty().WithMessage("Branch is required");

        RuleFor(x => x.CustomerId)
            .NotEqual(Guid.Empty).WithMessage("Invalid customer");

        RuleFor(x => x.Items)
            .NotEmpty().WithMessage("The sale must contain at least one item");

        RuleForEach(x => x.Items).ChildRules(items =>
        {
            items.RuleFor(i => i.Quantity)
                .InclusiveBetween(1, 20).WithMessage("The quantity must be between 1 and 20");

            items.RuleFor(i => i.Quantity)
                .Must((item, qtd) =>
                {
                    // do not allow discount if quantity < 4
                    if (qtd < 4)
                        return item.DiscountPercentage == 0;

                    // allow up to 10% for 4 to 9
                    if (qtd >= 4 && qtd < 10)
                        return item.DiscountPercentage <= 0.10m;

                    // allow up to 20% for 10 to 20
                    if (qtd >= 10 && qtd <= 20)
                        return item.DiscountPercentage <= 0.20m;

                    return true;
                })
                .WithMessage("Invalid discount for the quantity entered");
        });
    }
}
