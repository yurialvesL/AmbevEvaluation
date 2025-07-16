using Ambev.DeveloperEvaluation.WebApi.Configuration.Swagger;
using Microsoft.OpenApi.Models;

namespace Ambev.DeveloperEvaluation.WebApi.Common;

public static class SwaggerGenExtension
{
    public static IServiceCollection AddSwaggerGen(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "Ambev Developer Evaluation API",
                Version = "v1",
                Description = "API for Ambev Developer Evaluation",
                Contact = new Microsoft.OpenApi.Models.OpenApiContact
                {
                    Name = "Ambev Developer Team",
                    Email = "yuri.lima@ambev.com.br"
                }
            });

            c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12sdasdsa3"
            });

            c.OperationFilter<AuthorizeCheckOperationFilter>();

        });
        return services;
    }
}
        
