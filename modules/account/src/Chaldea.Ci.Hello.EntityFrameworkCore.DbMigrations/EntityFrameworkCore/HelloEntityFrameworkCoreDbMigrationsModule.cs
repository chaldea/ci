using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Chaldea.Ci.Hello.EntityFrameworkCore
{
    [DependsOn(
        typeof(HelloEntityFrameworkCoreModule)
        )]
    public class HelloEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<HelloMigrationsDbContext>();
        }
    }
}
