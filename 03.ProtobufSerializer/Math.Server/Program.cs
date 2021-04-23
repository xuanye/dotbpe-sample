using DotBPE.Extra;
using DotBPE.Rpc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Math.Server
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var builder = new HostBuilder()
             .UseRpcServer()
             .UseCastleDynamicProxy()
             .UseProtobufSerializer()
             .ConfigureLogging(logger =>
             {
                 logger.AddConsole();
             })
             .BindService<ServiceDefinition.MathService>();

            //启动
            builder.RunConsoleAsync().Wait();
        }
    }
}