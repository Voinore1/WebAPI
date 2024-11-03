using System.Net;

namespace WebAPI
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex.Message);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, string str, HttpStatusCode code = HttpStatusCode.InternalServerError)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            return context.Response.WriteAsJsonAsync(new {

                Message = str,
                StatusCode = code
            });

        }
    }
}
