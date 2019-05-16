using DotBPE.Extra;
using DotBPE.Gateway;
using DotBPE.Rpc;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Math.HttpServer
{
    public class Startup
    {

        public Startup(IConfiguration config)
        {
            this.Configuration = config;
        }

        IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //添加路由信息
            services.BindService<ServiceDefinition.MathService>(); //bindService        


            //add gateway and auto scan router infos
            services.AddGateway("Math.ServiceDefinition");
            

            services.AddMessagePackSerializer(); //message pack serializer
            services.AddJsonNetParser(); // http result json parser
            services.AddDynamicClientProxy(); // aop client
            services.AddDynamicServiceProxy(); // aop service
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {            
            //use gateway middleware
            app.UseGateway();

           
        }
    }
}
