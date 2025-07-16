using Ambev.DeveloperEvaluation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents an item in a sale transaction.
/// </summary>
public class SaleItem : BaseEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the product associated with this sale item.
    /// </summary>
    public Guid ProductId { get; set; }
    /// <summary>
    /// Gets or sets the quantity of the product sold in this sale item.
    /// </summary>
    public int Quantity { get; set; }
    /// <summary>
    /// Gets or sets the unit price of the product at the time of sale.
    /// </summary>
    public decimal UnitPrice { get; set; }
    /// <summary>
    /// gets or sets the discount percentage applied to this sale item.
    /// </summary>
    public decimal DiscountPercentage { get; set; }
    /// <summary>
    /// gets the total price for this sale item, calculated as:
    /// </summary>
    public decimal Total => Quantity * UnitPrice * (1 - DiscountPercentage);
}
