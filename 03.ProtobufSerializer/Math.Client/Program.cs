using DotBPE.Extra;
using DotBPE.Rpc;
using DotBPE.Rpc.Client;
using Math.ServiceDefinition;
using Peach.Infrastructure;
using System;
using Microsoft.Extensions.Logging;

namespace Math.Client
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var proxy = ClientProxyFactory.Create()
                .UseCastleDynamicClientProxy()
                .UseProtobufSerializer()
                .ConfigureLogging(logger =>
                {
                    logger.AddConsole();
                })
                .UseDefaultChannel($"{IPUtility.GetLocalIntranetIP().MapToIPv4()}:5566")
                .GetClientProxy();

            var mathService = proxy.Create<IMathService>();

            var random = new Random();

            var req = new SumReq { A = random.Next(100000), B = random.Next(100000) };
            var result = mathService.SumAsync(req).GetAwaiter().GetResult();

            if (result.Code == 0)
            {
                Console.WriteLine("Call Math Service Add {0}+{1}={2}", req.A, req.B, result.Data?.Total);
            }
            else
            {
                Console.WriteLine("Call Math Service Error,Code={0}", result.Code);
            }

            Console.WriteLine("Press any key to exit !");
            Console.ReadKey();
        }
    }
}