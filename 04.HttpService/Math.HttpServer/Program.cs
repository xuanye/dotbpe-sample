using Tomato.Extra;
using Tomato.Rpc;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Math.HttpServer
{
    static class Program
    {
        static void Main(string[] args)
        {
            //访问:http://localhost:5560/api/math/sum?a=1&b=100"
            BuildWebHost(args).Run();
        }

        static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:5560") //HTTP绑定在6200端口
                .UseStartup<Startup>()
                .ConfigureLogging((logger) => {

                    logger.SetMinimumLevel(LogLevel.Warning);
                    logger.AddConsole();
                })
                .Build();
    }
}
