using DotBPE.Protobuf;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc;
using DotBPE.Rpc.Hosting;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Survey.Core;
using Survey.Protocols;
using Vulcan.DataAccess;

namespace SurveyServerHost
{
    public static class ServerStartup
    {
        /// <summary>
        /// 配置注入的服务信息
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            // Add memory cache services
            services.AddMemoryCache();
            services.Configure<RedisCacheOptions>(context.Configuration.GetSection("redis"));           
            //添加分布式缓存的实现
            services.AddSingleton<IDistributedCache, RedisCache>();



            services.ScanAddDescriptorFactory("Survey.Protocols");
            //添加AuditLog日志
            services.AddAuditLog();

            // 使用AMP协议
            services.AddDotBPE();
            //注册服务接收器
            services.ScanAddServiceActors("Survey.Impl.");



            #region 数据库相关
            //获取数据库连接
            services.Configure<DBOption>(context.Configuration.GetSection("connectionStrings"));         
            //设置上下文，可以在上下文中存储对象 在一次请求中可以传递
            services.AddSingleton<IContextAccessor<AmpMessage>, DefaultContextAccessor<AmpMessage>>();
            //Vulcan数据层需要的对象，如果不使用Vulcan可以不用注册
            services.AddSingleton<IRuntimeContextStorage, DotBPECallContextStorage<AmpMessage>>();
            //链接管理器
            services.AddSingleton<IConnectionManagerFactory, ConnectionManagerFactory>();
            //使用MySQL
            services.AddSingleton<IConnectionFactory, MySqlConnectionFactory>();
            #endregion

            //添加挂载的宿主服务
            services.AddRpcHostedService();
        }

      
    }
}