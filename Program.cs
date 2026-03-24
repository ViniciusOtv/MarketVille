using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Events;

namespace MarktVille
{
    public class Program
    {
        public static int Main(string[] args)
        {
            // Configure Serilog to read configuration from appsettings.json
            // This allows dynamic configuration of logging levels and sinks.
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration) // Read Serilog configuration from IConfiguration
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning) // Suppress verbose Microsoft logs
                .MinimumLevel.Override("System", LogEventLevel.Warning)    // Suppress verbose System logs
                .Enrich.FromLogContext() // Add useful context properties to logs
                .WriteTo.Console()       // Output logs to console
                .WriteTo.File(           // Output logs to a rolling file
                    Path.Combine("logs", "log-.txt"),
                    rollingInterval: RollingInterval.Day, // Create a new log file daily
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();

            try
            {
                Log.Information("Starting web host");
                CreateWebHostBuilder(args).Build().Run();
                return 0; // Indicate successful execution
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                return 1; // Indicate abnormal termination
            }
            finally
            {
                Log.CloseAndFlush(); // Ensure all buffered log events are written
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog(); // Integrate Serilog with the ASP.NET Core logging pipeline
    }
}