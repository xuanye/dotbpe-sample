using Tomato.Extra;
using Tomato.Rpc;
using Tomato.Rpc.Client;
using Peach.Infrastructure;
using QuickStart.ServiceDefinition;
using System;

namespace QuickStart.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxy = ClientProxyFactory.Create()
              .UseCastleDynamicClientProxy()
              .UseMessagePackSerializer()
              .UseDefaultChannel($"{IPUtility.GetLocalIntranetIP().MapToIPv4()}:5566")
              .GetClientProxy();

            var service = proxy.Create<IQuickStartService>();

            // 项目中应保证异步到底的调用
            var res = service.SayHelloAsync(new SayHelloReq { Name = "Maxi" }).GetAwaiter().GetResult();

            Console.WriteLine(res?.Data?.GreetingWords);
            Console.WriteLine("Press any key to exit !");
            Console.ReadKey();
        }
    }
}