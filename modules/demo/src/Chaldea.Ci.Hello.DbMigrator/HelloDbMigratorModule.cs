﻿using Chaldea.Ci.Hello.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Chaldea.Ci.Hello.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(HelloEntityFrameworkCoreDbMigrationsModule),
        typeof(HelloApplicationContractsModule)
        )]
    public class HelloDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
