using Ambev.DeveloperEvaluation.Domain.Logging;
using Ambev.DeveloperEvaluation.ORM.Event;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Ambev.DeveloperEvaluation.IoC.ModuleInitializers;

public class LogEventModuleInitializer : IModuleInitializer
{
    public void Initialize(WebApplicationBuilder builder)
    {
        builder.Services.Configure<MongoDbOptions>(
            builder.Configuration.GetSection("MongoDb"));

        builder.Services.AddScoped<IEventLogRepository, EventLogRepository>();
        builder.Services.AddScoped<MongoDbContext>();
    }
}

