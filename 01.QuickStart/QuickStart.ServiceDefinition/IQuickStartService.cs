using Tomato.Rpc;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace QuickStart.ServiceDefinition
{
    [RpcService(1000)]
    public interface IQuickStartService
    {
        [RpcMethod(1)]
        Task<RpcResult<SayHelloRes>> SayHelloAsync(SayHelloReq req);
    }

    [DataContract]
    public class SayHelloReq
    {
        [DataMember(Name = "name", Order = 1)]
        public string Name { get; set; }
    }

    [DataContract]
    public class SayHelloRes
    {
        [DataMember(Name = "greetingWords", Order = 1)]
        public string GreetingWords { get; set; }
    }
}