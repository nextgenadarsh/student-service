using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using System;
using System.Net;

namespace Centoreal.StudentService.Extensions
{
    public static class ExceptionHandler
    {
        public static void UseCustomExceptionHandler(this IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseExceptionHandler(config => {
                config.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";

                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    if(error != null)
                    {
                        var ex = error.Error;

                        byte[] message = Convert.FromBase64String(ex.Message);
                        await context.Response.BodyWriter.WriteAsync(message);
                    }
                });
            });
        }
    }
}
