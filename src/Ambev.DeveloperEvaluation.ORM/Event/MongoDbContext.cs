using Ambev.DeveloperEvaluation.ORM.Event.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Event;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext(IOptions<MongoDbOptions> options)
    {
        var client = new MongoClient(options.Value.ConnectionString);
        _database = client.GetDatabase(options.Value.Database);
    }

    public IMongoCollection<SaleEventLog> EventLogs =>
        _database.GetCollection<SaleEventLog>("SaleEventLogs");
}
