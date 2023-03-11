using System.Text.Json;
using Tmf.Hunter.Core.Constants;
using Tmf.Hunter.Core.Exception;

namespace Tmf.Hunter.Api.Middleware
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            ErrorResponse errorResponse = new ErrorResponse();
            context.Request.Headers.TryGetValue("BpNo", out var bpNo);
            context.Request.Headers.TryGetValue("UserType", out var userType);

            //do the checking
            if (string.IsNullOrEmpty(Convert.ToString(bpNo)))
            {
                errorResponse.Message = ValidationMessages.BpNoHeader;
                var exceptionResult = JsonSerializer.Serialize(new { error = errorResponse.Message });
                context.Response.StatusCode = 401;
                context.Response.ContentType = ValidationMessages.ApplicationJson;
                await context.Response.WriteAsync(exceptionResult);
                return;
            }

            if (string.IsNullOrEmpty(Convert.ToString(userType)))
            {
                errorResponse.Message = ValidationMessages.UserTypeHeader;
                var exceptionResult = JsonSerializer.Serialize(new { error = errorResponse.Message });
                context.Response.StatusCode = 401;
                context.Response.ContentType = ValidationMessages.ApplicationJson;
                await context.Response.WriteAsync(exceptionResult);
                return;
            }
            await _next(context);

        }
    }
}
