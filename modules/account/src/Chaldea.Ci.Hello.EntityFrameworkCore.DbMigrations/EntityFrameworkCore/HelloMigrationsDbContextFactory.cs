using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Chaldea.Ci.Hello.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class HelloMigrationsDbContextFactory : IDesignTimeDbContextFactory<HelloMigrationsDbContext>
    {
        public HelloMigrationsDbContext CreateDbContext(string[] args)
        {
            HelloEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<HelloMigrationsDbContext>()
                .UseNpgsql(configuration.GetConnectionString("Default"));

            return new HelloMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Chaldea.Ci.Hello.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
