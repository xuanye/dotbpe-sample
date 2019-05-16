using DotBPE.AspNetGateway;
using DotBPE.Protocol.Amp;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Survey.Protocols;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SurveyGateway
{
    public class LoginPostProcesss : IHttpPostProcessPlugin<AmpMessage>
    {

        private static ILogger<LoginPostProcesss> _logger;
      
        public LoginPostProcesss(ILogger<LoginPostProcesss> logger)
        {           
            _logger = logger;           
        }

        public async Task<bool> PostProcessAsync(HttpRequest req, HttpResponse res, AmpMessage msg, HttpRouterOptionItem routeOption)
        {
            _logger.LogDebug("登录返回");
            if (msg.Code == 0) //登录成功
            {
                var rsp = LoginRsp.Parser.ParseFrom(msg.Data);
                if(rsp != null && !string.IsNullOrEmpty(rsp.Account))
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, rsp.Account) };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await res.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));  
                }
            }

            return false;
        }
    }
}
