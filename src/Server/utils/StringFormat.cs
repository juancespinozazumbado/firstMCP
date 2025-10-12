namespace Server.utils;

using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System.IO;

public static class StringFormat
{
    private static readonly ILogger _logger = LoggerProvider.CreateLogger();
    private static readonly int LimitTraceHold = 500;
    private static readonly String FormatterId = Guid.NewGuid().ToString();


/// <summary>
/// Formats the string configuration.
/// </summary>
/// <param name="config"></param>
/// <exception cref="Exception"></exception>
    public static void FormatStringConfig(string config)
    {
        if (string.IsNullOrEmpty(config))
        {
            throw new Exception("string must not be an empty string");
        }

    }

/// <summary>
/// Assigns configuration files.
/// </summary>
/// <param name="configOptions"></param>
/// <param name="file"></param>
/// <exception cref="Exception"></exception>
    public static void AssignConfigFiles(object configOptions, FileInfo file = null)
    {

        if (file is null)
        {
            throw new Exception("File can't be null");
        }
    }

}