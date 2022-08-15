using Layered.Core.CrossCuttingConcers.Caching;
using Layered.Core.CrossCuttingConcers.Caching.Microsoft;
using Layered.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layered.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
