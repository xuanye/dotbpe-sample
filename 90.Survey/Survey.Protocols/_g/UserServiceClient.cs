// Generated by the protocol buffer compiler. DO NOT EDIT!
// source: service/userService_20003.proto
#region Designer generated code

using System;
using System.Threading.Tasks;
using DotBPE.Rpc;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc.Exceptions;
using Google.Protobuf;
using DotBPE.Rpc.Client;

namespace Survey.Protocols {

    //start for class UserServiceClient
    public sealed class UserServiceClient : AmpInvokeClient
    {
        public UserServiceClient(ICallInvoker<AmpMessage> callInvoker) : base(callInvoker)
        {

        }

        //同步方法
        public RpcResult<RegisterRsp> Register(RegisterReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20003, 1);

            message.FriendlyServiceName = "UserService.Register";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<RegisterRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data  =  new RegisterRsp();
            }
            else
            {
                result.Data = RegisterRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        public async Task<RpcResult<RegisterRsp>> RegisterAsync(RegisterReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20003, 1);
            message.FriendlyServiceName = "UserService.Register";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<RegisterRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data = new RegisterRsp();
            }
            else
            {
                result.Data = RegisterRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<LoginRsp> Login(LoginReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20003, 2);

            message.FriendlyServiceName = "UserService.Login";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<LoginRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data  =  new LoginRsp();
            }
            else
            {
                result.Data = LoginRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        public async Task<RpcResult<LoginRsp>> LoginAsync(LoginReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20003, 2);
            message.FriendlyServiceName = "UserService.Login";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<LoginRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data = new LoginRsp();
            }
            else
            {
                result.Data = LoginRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<EditUserRsp> Edit(EditUserReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20003, 3);

            message.FriendlyServiceName = "UserService.Edit";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<EditUserRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data  =  new EditUserRsp();
            }
            else
            {
                result.Data = EditUserRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        public async Task<RpcResult<EditUserRsp>> EditAsync(EditUserReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20003, 3);
            message.FriendlyServiceName = "UserService.Edit";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<EditUserRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data = new EditUserRsp();
            }
            else
            {
                result.Data = EditUserRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<GetUserRsp> GetUserInfo(GetUserReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20003, 4);

            message.FriendlyServiceName = "UserService.GetUserInfo";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<GetUserRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data  =  new GetUserRsp();
            }
            else
            {
                result.Data = GetUserRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        public async Task<RpcResult<GetUserRsp>> GetUserInfoAsync(GetUserReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20003, 4);
            message.FriendlyServiceName = "UserService.GetUserInfo";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<GetUserRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data = new GetUserRsp();
            }
            else
            {
                result.Data = GetUserRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<GetUserRsp> CheckLogin(VoidReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20003, 5);

            message.FriendlyServiceName = "UserService.CheckLogin";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<GetUserRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data  =  new GetUserRsp();
            }
            else
            {
                result.Data = GetUserRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        public async Task<RpcResult<GetUserRsp>> CheckLoginAsync(VoidReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20003, 5);
            message.FriendlyServiceName = "UserService.CheckLogin";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<GetUserRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            
            if (response.Data == null)
            {
                result.Data = new GetUserRsp();
            }
            else
            {
                result.Data = GetUserRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

    }
    //end for class UserServiceClient
}
#endregion