using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Event;

public class MongoDbOptions
{
    public string ConnectionString { get; set; } = string.Empty;

    public string Database { get; set; } = string.Empty;
}
