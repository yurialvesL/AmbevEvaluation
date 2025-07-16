using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Common.Security.Entities;

/// <summary>
/// Defines the properties and methods for a sale entity in the system.
/// </summary>
public interface ISale
{
    /// <summary>
    /// Get the number of that sale.
    /// </summary>
    string SaleNumber { get;}

    /// <summary>
    /// Get the branch where the sale was made.
    /// </summary>
    string Branch { get;}
}
