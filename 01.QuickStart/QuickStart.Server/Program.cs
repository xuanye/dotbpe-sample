using DotBPE.Extra;
using DotBPE.Rpc;
using Microsoft.Extensions.Hosting;

namespace QuickStart.Server
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new HostBuilder()
             .UseRpcServer()
             .UseCastleDynamicProxy()
             .UseMessagePackSerializer()
             .BindService<ServiceDefinition.QuickStartService>();

            //启动
            builder.RunConsoleAsync().Wait();
        }
    }
}