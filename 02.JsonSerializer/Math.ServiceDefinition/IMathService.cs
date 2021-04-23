using System.Runtime.Serialization;
using System.Threading.Tasks;
using DotBPE.Rpc;

namespace Math.ServiceDefinition
{
    /// <summary>
    /// 数学服务
    /// </summary>
    [RpcService(100)]
    public interface IMathService
    {
        /// <summary>
        /// 加法服务
        /// </summary>
        /// <param name="req">请求参数req</param>
        /// <returns>返回值Res</returns>
        [RpcMethod(1)]
        Task<RpcResult<SumRes>> SumAsync(SumReq req);
    }


    /// <summary>
    /// 加法返回值
    /// </summary>
    [DataContract]
    public class SumRes
    {
        /// <summary>
        /// 总记录
        /// </summary>
        [DataMember(Name = "total")]
        public int Total { get; set; }

    }

    /// <summary>
    /// 加法请求
    /// </summary>
    [DataContract]
    public class SumReq
    {
        /// <summary>
        /// 字段A
        /// </summary>
        [DataMember(Name = "a")]
        public int A { get; set; }

        /// <summary>
        /// 字段B
        /// </summary>
        [DataMember(Name = "b")]
        public int B { get; set; }
    }
}
