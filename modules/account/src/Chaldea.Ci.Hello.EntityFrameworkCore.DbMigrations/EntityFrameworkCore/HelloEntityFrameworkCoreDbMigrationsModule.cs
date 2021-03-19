using Chaldea.Ci.Hello.Data;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
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

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            context.ServiceProvider
                .GetRequiredService<HelloDbMigrationService>()
                .MigrateAsync()
                .Wait();
        }
    }
}
