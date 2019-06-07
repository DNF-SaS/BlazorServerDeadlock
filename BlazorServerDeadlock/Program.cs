// <copyright file="Program.cs" company="DotNetFabrik">
//     Copyright (c) DotNetFabrik － All rights reserved.
// </copyright>

namespace BlazorServerDeadlock
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureLogging(lb => lb
                            .AddDebug()
                            .AddConsole()
                            .SetMinimumLevel(LogLevel.Trace));

                    webBuilder.UseStartup<Startup>();
                });
    }
}
