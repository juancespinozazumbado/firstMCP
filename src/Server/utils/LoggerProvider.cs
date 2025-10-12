namespace Server.utils;

using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

public static class LoggerProvider
{

    private static ILoggerFactory factory { get; } = Microsoft.Extensions.Logging.LoggerFactory.Create(builder =>
    {
        builder.AddConsole();
        builder.SetMinimumLevel(LogLevel.Information);
    });

    /// <summary>
    /// Creates a logger of type T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static ILogger<T> CreateLogger<T>() => factory.CreateLogger<T>();
    public static ILogger CreateLogger() => factory.CreateLogger("DefaultLogger");
}