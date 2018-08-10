using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace WebApiCoreSwagger.Extensions
{
    public static class SwaggerServiceExtensions
    {
        #region Swagger
        public static IServiceCollection AddSwaggerDoc(this IServiceCollection services)
        {
            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1.0", new Info { Title = "Discount Engine API", Version = "v1.0" });

            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint("/swagger/v1.0/swagger.json", "v1.0");
            });

            return app;
        }

        #endregion Swagger

        #region Swagger With Barber token
        public static IServiceCollection AddSwaggerWithBearerToken(this IServiceCollection services)
        {
            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1.0", new Info { Title = "You API Name", Version = "v1.0" });

            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerWithBearerToken(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint("/swagger/v1.0/swagger.json", "v1.0");
                option.RoutePrefix = string.Empty;
            });

            return app;
        }

        #endregion Swagger With Barber token
    }
}
