// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Logging;
using Server.utils;

Console.WriteLine("Hello, World!");

ILogger<Program> logger = LoggerProvider.CreateLogger<Program>();   
logger.LogInformation("This is an information message from {Program}", nameof(Program));
logger.LogWarning("This is a warning message from {Program}", nameof(Program));
