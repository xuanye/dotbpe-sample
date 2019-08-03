using Tomato.Extra;
using Tomato.Gateway;
using Tomato.Gateway.Swagger;
using Tomato.Gateway.Swagger.Generator;
using Tomato.Gateway.SwaggerUI;
using Tomato.Rpc;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace SwaggerSample.HttpServer
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            this.Configuration = config;
        }

        private IConfiguration Configuration { get; }

        /// <summary>
        ///  This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>     
        public void ConfigureServices(IServiceCollection services)
        {
            //添加路由信息
            services.BindService<ServiceDefinition.SwaggerSampleService>(); //bindService

            //add gateway and auto scan router infos
            services.AddGateway($"{typeof(ServiceDefinition.SwaggerSampleService).Assembly.GetName().Name}");

            services.AddMessagePackSerializer(); //message pack serializer
            services.AddJsonNetParser(); // http result json parser
            services.AddDynamicClientProxy(); // aop client
            services.AddDynamicServiceProxy(); // aop service

            //Add Swagger
            services.AddSwagger();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>       
        public void Configure(IApplicationBuilder app)
        {
            app.UseSwagger(config =>
            {
                //config.RoutePath = "/v2/swagger.json";
                config.ApiInfo = new SwaggerApiInfo
                {
                    Title = "SwaggerSampleApp",
                    Description = "Sample Service Swagger",
                    Version = "1.0"
                };

                var xmlFile = $"{typeof(ServiceDefinition.SwaggerSampleService).Assembly.GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                config.IncludeXmlComments(xmlPath);
            });

            app.UseStaticFiles();

            app.UseSwaggerUI(config => { config.RoutePrefix = "/swagger"; });

            //use gateway middleware
            app.UseGateway();
        }
    }
}