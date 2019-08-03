using CommandLine;
using Tomato.Rpc;
using Tomato.Protocol.Amp;
using Tomato.Rpc.Client;
using Tomato.Rpc.Utils;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Tomato.Protobuf;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace QuickTest
{
    public class InteropClient
    {
        private static readonly JsonFormatter AmpJsonFormatter = new JsonFormatter(new JsonFormatter.Settings(true).WithFormatEnumsAsIntegers(true));

        private class ClientOption
        {
            [Option("server", Default = "127.0.0.1:5501")]
            public string Server { get; set; }

            [Option("testcase", Default = "default")]
            public string TestCase { get; set; }

            [Option("mpc", Default = 1)]
            public int MultiplexCount { get; set; }
        }

        private readonly ClientOption _options;

        private InteropClient(ClientOption options)
        {
            this._options = options;
        }

        private static int TOTAL_ERROR = 0;

        public static void Run(string[] args)
        {
            var parserResult = Parser.Default.ParseArguments<ClientOption>(args)
            .WithNotParsed(errors =>
            {
                Console.WriteLine(errors);
                System.Environment.Exit(1);
            })
            .WithParsed(options =>
            {
                var interopClient = new InteropClient(options);
                Console.WriteLine("Start to Run!");
                TOTAL_ERROR = 0;
                var swTotal = new Stopwatch();
                swTotal.Start();
                interopClient.Run();
                swTotal.Stop();
                Console.WriteLine("---------------------Summary:--------------------------");
                Console.WriteLine("Error times: {0}", TOTAL_ERROR);
                Console.WriteLine("Elapsed time: {0}ms", swTotal.ElapsedMilliseconds);
                Console.ReadKey();
            });
        }

        private void Run()
        {
            //读取测试的文件
            var tcFilePath = Path.Combine(CommonUtils.GetAppRootPath(), "testcase", this._options.TestCase + ".txt");

            if (!File.Exists(tcFilePath))
            {
                Console.WriteLine(tcFilePath);
                Console.WriteLine("对应的测试文件不存在");
                System.Environment.Exit(1);
                return;
            }
            Dictionary<string, TestCase> tcCache = new Dictionary<string, TestCase>();
            using (StreamReader reader = File.OpenText(tcFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.StartsWith("#"))
                    {
                        continue;
                    }

                    var tc = ParseFromLine(line);
                    tcCache.Add(tc.Id, tc);
                }
            }

            var proxy = new ClientProxyBuilder()
                .UseServer(this._options.Server)
                .ConfigureServices(services =>
                {
                    services.ScanAddDescriptorFactory();
                    services.AddMessageParser();
                })
                .ConfigureLoggingServices(logger => logger.AddConsole())
                .BuildDefault();

           
            //创建链接         

            using(var caller = proxy.GetService<ICallInvoker<AmpMessage>>())
            {
                var parser = proxy.GetService<IMessageParser<AmpMessage>>();
                //开始跑测试了
                foreach (var kvtc in tcCache)
                {
                    RunTestCase(caller, kvtc.Value, parser);
                }
            }
            
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="tc"></param>
        private void RunTestCase(ICallInvoker<AmpMessage> caller, TestCase tc, IMessageParser<AmpMessage> parser)
        {
            try
            {
                Console.WriteLine("--------start run testcase {0}-----------", tc.Id);
                Console.WriteLine("ServiceId: {0},MessageId:{1},Req:{2}", tc.ServiceId, tc.MessageId, tc.Json);
                              
                RequestData rd = new RequestData();
                rd.ServiceId = tc.ServiceId;
                rd.MessageId = tc.MessageId;
                rd.Data = new Dictionary<string, string>();
                rd.RawBody = tc.Json;

                AmpMessage req = parser.ToMessage(rd);

                if(req == null)
                {
                    TOTAL_ERROR++;
                    Console.WriteLine("协议转换出错，请检查serviceId={0}和messageId={1}",tc.ServiceId,tc.MessageId);
                    System.Environment.Exit(1);
                    return;
                }

                AmpMessage rsp = caller.BlockingCall(req);

                if (rsp == null)
                {
                    TOTAL_ERROR++;
                    Console.WriteLine(">>----end run testcase {0} fail,no repsonse--------", tc.Id);
                }
                else
                {
                    Console.WriteLine(">>----end run testcase {0} success,response code = {1}-------", tc.Id, rsp.Code);

                    var jsonRsp = parser.ToJson(rsp);

                    if (string.IsNullOrEmpty(jsonRsp))
                    {
                        TOTAL_ERROR++;
                        Console.WriteLine(">>----end run testcase {0} fail,没有配置对应服务响应消息---------", tc.Id);
                    }
                    else
                    {
                        Console.WriteLine(">>response:{0}", jsonRsp);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("执行测试出错:" + ex.Message);
                System.Environment.Exit(1);
            }
        }

        private TestCase ParseFromLine(string line)
        {
            TestCase tc = new TestCase();

            if (line.StartsWith("$"))
            {
                var tcData = line.Split(new char[] { ',' }, 4);
                tc.Id = tcData[0].Substring(1);
                tc.ServiceId = ushort.Parse(tcData[1]);
                tc.MessageId = ushort.Parse(tcData[2]);
                tc.Json = tcData[3];
            }
            else
            {
                tc.Id = Guid.NewGuid().ToString("N");
                var tcData = line.Split(new char[] { ',' }, 3);
                tc.ServiceId = ushort.Parse(tcData[0]);
                tc.MessageId = ushort.Parse(tcData[1]);
                tc.Json = tcData[2];
            }

            return tc;
        }
    }
}
