using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Chaldea.Ci.Hello.Data;
using Volo.Abp.DependencyInjection;

namespace Chaldea.Ci.Hello.EntityFrameworkCore
{
    public class EntityFrameworkCoreHelloDbSchemaMigrator
        : IHelloDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreHelloDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the HelloMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<HelloMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}