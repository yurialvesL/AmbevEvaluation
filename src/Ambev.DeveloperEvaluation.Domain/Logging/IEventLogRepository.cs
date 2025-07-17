using Ambev.DeveloperEvaluation.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Logging;

/// <summary>
/// Repitory interface for managing sales events in the system.
/// </summary>
public interface IEventLogRepository
{
    /// <summary>
    /// Asynchronously saves the specified event log entry to the underlying storage.
    /// </summary>
    /// <param name="log">The event log entry to save. This parameter cannot be <see langword="null"/>.</param>
    /// <returns>A task that represents the asynchronous save operation.</returns>
    Task SaveAsync(EventLogEntry log);
}
