using DotBPE.Rpc;
using DotBPE.Rpc.Server;
using System;
using System.Threading.Tasks;

namespace Math.ServiceDefinition
{
    public class MathService : BaseService<IMathService>, IMathService
    {
        public Task<RpcResult<SumRes>> SumAsync(SumReq req)
        {
            var result = new RpcResult<SumRes> { Data = new SumRes() };
            result.Data.Total = req.A + req.B;

            Console.WriteLine("A+B=C {0}+{1}={2}", req.A, req.B, result.Data.Total);

            return Task.FromResult(result);
        }
    }
}