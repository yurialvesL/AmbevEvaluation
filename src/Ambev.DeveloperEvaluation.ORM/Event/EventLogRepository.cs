using Ambev.DeveloperEvaluation.Domain.DTOs;
using Ambev.DeveloperEvaluation.Domain.Logging;
using Ambev.DeveloperEvaluation.ORM.Event.Mappings;
using Ambev.DeveloperEvaluation.ORM.Event.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Event;

/// <summary>
/// Represents a repository for managing event logs in the system.
/// </summary>
public class EventLogRepository : IEventLogRepository
{
    private readonly IMongoCollection<SaleEventLog> _collection;

    public EventLogRepository(MongoDbContext context)
    {
        _collection = context.EventLogs;
    }

    /// <summary>
    /// Saves an event log entry to the database.
    /// </summary>
    public async Task SaveAsync(EventLogEntry logEntry)
    {
        var mapped = EventLogMapper.ToModel(logEntry);

        await _collection.InsertOneAsync(mapped);
    }
}
