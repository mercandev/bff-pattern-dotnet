using System;
using Bff.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Bff.Infrastructure.Engine;

public static class ExceptionHandlerRegister
{
    public static WebApplication UseExceptionHandlerRegister(this WebApplication app)
    {
        return (WebApplication)app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.ContentType = "application/json";

                var exception = context.Features.Get<IExceptionHandlerFeature>();

                if (exception != null && exception.Error is BffCustomException || exception.Error is Exception)
                {
                    await context.Response.WriteAsync(new CustomExceptionResponse
                    {
                        ErrorMessage = exception.Error.Message

                     }.ToString());
                }
            });
        });
    }
}