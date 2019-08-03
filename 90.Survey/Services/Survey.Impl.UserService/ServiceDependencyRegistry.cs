using Tomato.Rpc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Survey.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Impl
{
    public class ServiceDependencyRegistry : IServiceDependencyRegistry
    {     

        public IServiceCollection AddServiceDependency(IConfiguration configuration, IServiceCollection services)
        {
            return services.AddSingleton<UserRepository>();
        }
    }
}
