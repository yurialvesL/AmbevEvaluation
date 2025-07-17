using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.DTOs;

// <summary>
// Represents an entry in the event log, capturing the type of event, its payload, and the timestamp of when it occurred.
// </summary>
public class EventLogEntry
{
    public string EventType { get; set; } = default!;
    public string Payload { get; set; } = default!;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
