using System.Threading.Tasks;

namespace Chaldea.Ci.Hello.Data
{
    public interface IHelloDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
