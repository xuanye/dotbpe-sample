// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: service/userService_20003.proto

#region Designer generated code

using Tomato.Protocol.Amp;
using Tomato.Rpc;
using Google.Protobuf;
using System.Threading.Tasks;

namespace Survey.Protocols
{
    //start for class AbstractUserService
    public abstract class UserServiceBase : ServiceActor
    {
        protected override int ServiceId => 20003;


        public override Task<AmpMessage> ProcessAsync(AmpMessage req)
        {
            switch (req.MessageId)
            {

                //方法 UserService.Register
                case 1: return this.ProcessRegisterAsync(req);

                //方法 UserService.Login
                case 2: return this.ProcessLoginAsync(req);

                //方法 UserService.Edit
                case 3: return this.ProcessEditAsync(req);

                //方法 UserService.GetUserInfo
                case 4: return this.ProcessGetUserInfoAsync(req);

                //方法 UserService.CheckLogin
                case 5: return this.ProcessCheckLoginAsync(req);

                default: return base.ProcessNotFoundAsync(req);
            }
        }



        //调用委托
        private async Task<AmpMessage> ProcessRegisterAsync(AmpMessage req)
        {
            RegisterReq request = null;

            if (req.Data == null)
            {
                request = new RegisterReq();
            }
            else
            {
                request = RegisterReq.Parser.ParseFrom(req.Data);
            }

            req.FriendlyServiceName = "UserService.Register";

            var result = await RegisterAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);

            response.FriendlyServiceName = "UserService.Register";
            response.Code = result.Code;
            if (result.Data != null)
            {
                response.Data = result.Data.ToByteArray();
            }
            return response;
        }
        //抽象方法
        public abstract Task<RpcResult<RegisterRsp>> RegisterAsync( RegisterReq req);

        //调用委托
        private async Task<AmpMessage> ProcessLoginAsync(AmpMessage req)
        {
            LoginReq request = null;

            if (req.Data == null)
            {
                request = new LoginReq();
            }
            else
            {
                request = LoginReq.Parser.ParseFrom(req.Data);
            }

            req.FriendlyServiceName = "UserService.Login";

            var result = await LoginAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);

            response.FriendlyServiceName = "UserService.Login";
            response.Code = result.Code;
            if (result.Data != null)
            {
                response.Data = result.Data.ToByteArray();
            }
            return response;
        }
        //抽象方法
        public abstract Task<RpcResult<LoginRsp>> LoginAsync( LoginReq req);

        //调用委托
        private async Task<AmpMessage> ProcessEditAsync(AmpMessage req)
        {
            EditUserReq request = null;

            if (req.Data == null)
            {
                request = new EditUserReq();
            }
            else
            {
                request = EditUserReq.Parser.ParseFrom(req.Data);
            }

            req.FriendlyServiceName = "UserService.Edit";

            var result = await EditAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);

            response.FriendlyServiceName = "UserService.Edit";
            response.Code = result.Code;
            if (result.Data != null)
            {
                response.Data = result.Data.ToByteArray();
            }
            return response;
        }
        //抽象方法
        public abstract Task<RpcResult<EditUserRsp>> EditAsync( EditUserReq req);

        //调用委托
        private async Task<AmpMessage> ProcessGetUserInfoAsync(AmpMessage req)
        {
            GetUserReq request = null;

            if (req.Data == null)
            {
                request = new GetUserReq();
            }
            else
            {
                request = GetUserReq.Parser.ParseFrom(req.Data);
            }

            req.FriendlyServiceName = "UserService.GetUserInfo";

            var result = await GetUserInfoAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);

            response.FriendlyServiceName = "UserService.GetUserInfo";
            response.Code = result.Code;
            if (result.Data != null)
            {
                response.Data = result.Data.ToByteArray();
            }
            return response;
        }
        //抽象方法
        public abstract Task<RpcResult<GetUserRsp>> GetUserInfoAsync( GetUserReq req);

        //调用委托
        private async Task<AmpMessage> ProcessCheckLoginAsync(AmpMessage req)
        {
            VoidReq request = null;

            if (req.Data == null)
            {
                request = new VoidReq();
            }
            else
            {
                request = VoidReq.Parser.ParseFrom(req.Data);
            }

            req.FriendlyServiceName = "UserService.CheckLogin";

            var result = await CheckLoginAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);

            response.FriendlyServiceName = "UserService.CheckLogin";
            response.Code = result.Code;
            if (result.Data != null)
            {
                response.Data = result.Data.ToByteArray();
            }
            return response;
        }
        //抽象方法
        public abstract Task<RpcResult<GetUserRsp>> CheckLoginAsync( VoidReq req);

    }

    //end for class AbstractUserService
}

#endregion Designer generated code