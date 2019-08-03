using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Serilog;
using Microsoft.Extensions.Hosting;

namespace SurveyServerHost
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //任务系统出错的情况
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

            //配置Dapper的映射方式
            //设置dapper在查询映射字符串时支持user_id -> UserId
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;

            // 创建Host ，这里可以进一步简化
            var host = new HostBuilder()
                .ConfigureHostConfiguration(builder =>
                {
                    builder.AddJsonFile("hosting.json", optional: true)
                   .AddCommandLine(args)
                   .AddEnvironmentVariables(prefix: "Tomato_");
                })
                .ConfigureAppConfiguration((hostContext, config) =>
                {
                    config.AddJsonFile("Tomato.json", optional: true, reloadOnChange: true)
                      .AddJsonFile($"Tomato.{hostContext.HostingEnvironment.EnvironmentName}.json", optional: true)
                      .AddJsonFile("serilog.json", optional: false, reloadOnChange: false)
                      .AddJsonFile($"serilog.{hostContext.HostingEnvironment.EnvironmentName}.json", optional: true)
                      .AddEnvironmentVariables(prefix: "Tomato_");
                })
                .ConfigureLogging((context, factory) =>
                {
                    Log.Logger = new LoggerConfiguration()
                     .ReadFrom.Configuration(context.Configuration)
                     .CreateLogger();

                    //添加
                    factory.AddSerilog(dispose: true);
                })
                .ConfigureServices(ServerStartup.ConfigureServices);

            host.RunConsoleAsync().Wait();
            Console.WriteLine("服务已退出");
        }

        private static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            try
            {
                Log.Error(e.Exception, "TaskScheduler error");
                Console.WriteLine(e.Exception.ToString());
            }
            catch
            {
            }
        }
    }
}