using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Chaldea.Ci.Hello.Data
{
    /* This is used if database provider does't define
     * IHelloDbSchemaMigrator implementation.
     */
    public class NullHelloDbSchemaMigrator : IHelloDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}