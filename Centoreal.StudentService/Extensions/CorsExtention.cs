using Microsoft.Extensions.DependencyInjection;

namespace Centoreal.StudentService.Extensions
{
    public static class CorsExtention
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }
    }
}
