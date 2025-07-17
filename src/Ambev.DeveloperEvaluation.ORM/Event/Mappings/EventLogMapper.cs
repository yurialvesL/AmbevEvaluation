using Ambev.DeveloperEvaluation.Domain.DTOs;
using Ambev.DeveloperEvaluation.ORM.Event.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Event.Mappings;

public static class EventLogMapper
{
    public static SaleEventLog ToModel(EventLogEntry entry)
    {
        return new SaleEventLog
        {
            EventType = entry.EventType,
            Payload = entry.Payload,
            Timestamp = entry.Timestamp
        };
    }
}
