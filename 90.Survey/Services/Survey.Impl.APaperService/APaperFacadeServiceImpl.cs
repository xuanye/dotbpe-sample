using DotBPE.Protocol.Amp;
using DotBPE.Rpc;
using Survey.Protocols;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Impl
{
    public class APaperFacadeServiceImpl : APaperFacadeServiceBase
    {
        private readonly IClientProxy _proxy;
        public APaperFacadeServiceImpl(IClientProxy proxy)
        {
            this._proxy = proxy;
        }
        public async override Task<RpcResult<QPaperStaRsp>> GetAPaperStaAsync(GetQPaperStaReq request)
        {
            var res = new RpcResult<QPaperStaRsp>();
            res.Data = new QPaperStaRsp();
            if (string.IsNullOrEmpty(request.Identity))
            {
                res.Code = Survey.Core.ErrorCodes.AUTHORIZATION_REQUIRED;
                res.Data.ReturnMessage = "请先登录";
                return res;
            }

            var ap_client = _proxy.GetClient<APaperServiceClient>();
            var qp_client = _proxy.GetClient<QPaperServiceClient>();

            var req1 = new GetAPaperStaDetailReq();
            req1.ClientIp = request.ClientIp;
            req1.Identity = request.Identity;
            req1.XRequestId = request.XRequestId;
            req1.QpaperId = request.QpaperId;

            var t1 = ap_client.GetAPaperStaAsync(req1);
            var req2 = new GetQPaperReq();
            req2.ClientIp = request.ClientIp;
            req2.Identity = request.Identity;
            req2.XRequestId = request.XRequestId;
            req2.QpaperId = request.QpaperId;
            var t2 = qp_client.GetQPaperFullAsync(req2);

            await Task.WhenAll(t1, t2);

            if (t1.Result.Code != 0)
            {
                res.Code = t1.Result.Code;
                res.Data.ReturnMessage = t1.Result.Data.ReturnMessage;
                return res;
            }
            if (t2.Result.Code != 0)
            {
                res.Code = t2.Result.Code;
                res.Data.ReturnMessage = t2.Result.Data.ReturnMessage;
                return res;
            }

            res.Data.Qpaper = t2.Result.Data.Qpaper;
            res.Data.StaDetail.AddRange(t1.Result.Data.StaDetail);

            return res;
        }
    }
}
