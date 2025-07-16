using Ambev.DeveloperEvaluation.Common.Security.Entities;
using Ambev.DeveloperEvaluation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a sale transaction in the system.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>

public class Sale : BaseEntity, ISale
{

    /// <summary>
    /// Gets or sets the unique identifier for the sale.
    /// </summary>
    public string SaleNumber { get;  set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date and time when the sale was made.
    /// </summary>
    public DateTime SaleDate { get;  set; }

    /// <summary>
    /// Gets or sets the unique identifier of the customer associated with the sale.
    /// </summary>
    public Guid CustomerId { get;  set; }

    /// <summary>
    /// Gets or sets the branch where the sale was made.
    /// </summary>
    public string Branch { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the identifier if the sale was cancelled.
    /// </summary>
    public bool IsCancelled { get; set; }

    /// <summary>
    /// Represents the total amount of the sale.
    /// </summary>
    public decimal TotalAmount => Items.Sum(i => i.Total);

    /// <summary>
    /// Gets or sets the list of items included in the sale.
    /// Each item represents a product sold in the transaction.
    public List<SaleItem> Items { get; set; } = new();

}
