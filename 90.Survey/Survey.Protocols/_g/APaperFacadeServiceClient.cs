// Generated by the protocol buffer compiler. DO NOT EDIT!
// source: service/apaperFacadeService_10002.proto
#region Designer generated code

using System;
using System.Threading.Tasks;
using DotBPE.Rpc;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc.Exceptions;
using Google.Protobuf;
using DotBPE.Rpc.Client;

namespace Survey.Protocols {

    //start for class APaperFacadeServiceClient
    public sealed class APaperFacadeServiceClient : AmpInvokeClient
    {
        public APaperFacadeServiceClient(ICallInvoker<AmpMessage> callInvoker) : base(callInvoker)
        {

        }

        //同步方法
        public RpcResult<QPaperStaRsp> GetAPaperSta(GetQPaperStaReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10002, 1);

            message.FriendlyServiceName = "APaperFacadeService.GetAPaperSta";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<QPaperStaRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data  =  new QPaperStaRsp();
            }
            else
            {
                result.Data = QPaperStaRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        public async Task<RpcResult<QPaperStaRsp>> GetAPaperStaAsync(GetQPaperStaReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(10002, 1);
            message.FriendlyServiceName = "APaperFacadeService.GetAPaperSta";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<QPaperStaRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data = new QPaperStaRsp();
            }
            else
            {
                result.Data = QPaperStaRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

    }
    //end for class APaperFacadeServiceClient
}
#endregion