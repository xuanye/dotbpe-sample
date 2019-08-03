using Tomato.Extra;
using Tomato.Rpc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Math.Server
{
    static class Program
    {
        static void Main(string[] args)
        {
            var builder = new HostBuilder()
             .UseRpcServer()
             .UseCastleDynamicProxy()
             .UseJsonNetSerializer()
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
