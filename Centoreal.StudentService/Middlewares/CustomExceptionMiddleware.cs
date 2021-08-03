//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Http;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Centoreal.StudentService.Middlewares
//{
//    public class CustomExceptionMiddleware
//    {
//        public async Task Invoke(HttpContext httpContext)
//        {
//            try
//            {
//                await _next(httpContext);
//            } catch(Exception ex)
//            {
//                _logger.LogError("Unhandled exception ...", ex);
//                await HandleExceptionAsync(httpContext, ex);
//            }
//        }

//        public static IApplicationBuilder UseCustomExceptionMiddleware(this IApplicationBuilder applicationBuilder)
//        {
//            return applicationBuilder.UseMiddleware<CustomExceptionMiddleware>();
//        }
//    }
//}
