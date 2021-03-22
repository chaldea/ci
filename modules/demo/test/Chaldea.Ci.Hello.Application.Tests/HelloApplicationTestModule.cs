using Volo.Abp.Modularity;

namespace Chaldea.Ci.Hello
{
    [DependsOn(
        typeof(HelloApplicationModule),
        typeof(HelloDomainTestModule)
        )]
    public class HelloApplicationTestModule : AbpModule
    {

    }
}