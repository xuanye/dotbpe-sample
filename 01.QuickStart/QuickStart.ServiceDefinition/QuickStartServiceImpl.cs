using DotBPE.Rpc;
using DotBPE.Rpc.Server;
using System.Threading.Tasks;

namespace QuickStart.ServiceDefinition
{
    public class QuickStartService : BaseService<IQuickStartService>, IQuickStartService
    {
        public Task<RpcResult<SayHelloRes>> SayHelloAsync(SayHelloReq req)
        {
            var result = new RpcResult<SayHelloRes> { Data = new SayHelloRes() };

            result.Code = 0;
            result.Data.GreetingWords = $"Hello {req.Name},Welcome to DotBPE!";
            return Task.FromResult(result);
        }
    }
}