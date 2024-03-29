﻿using Newtonsoft.Json;
using System.Net;

namespace GymManager.UI.Middlewares;

public class ExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlerMiddleware> _logger;

    public ExceptionHandlerMiddleware(
        RequestDelegate next,
        ILogger<ExceptionHandlerMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception exception)
        {
            _logger.LogError(
                exception,
                $"Not handled exception! Request path: {context.Request.Path}");

            await HandleExceptionAsync(context, exception).ConfigureAwait(false);
        }
    }

    private Task HandleExceptionAsync(
        HttpContext context,
        Exception exception)
    {
        context.Response.ContentType = "application/json";

        int statusCode = (int)HttpStatusCode.InternalServerError;

        var result = JsonConvert.SerializeObject(new
        {
            StatusCode = statusCode,
            ErrorMessage = exception.Message
        });

        context.Response.Redirect(
            $"{context.Request.Scheme}://{context.Request.Host}/Error");

        return context.Response.WriteAsync(result);
    }
}
