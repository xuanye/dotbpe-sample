using DotBPE.Rpc;
using Microsoft.Extensions.DependencyInjection;
using Survey.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.Impl
{
    public class ServiceDependencyRegistry : IServiceDependencyRegistry
    {
        public IServiceCollection AddServiceDependency(IServiceCollection services)
        {
            return services.AddSingleton<APaperRepository>();
        }
        
    }
}
