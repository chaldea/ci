using Chaldea.Ci.Hello.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Chaldea.Ci.Hello
{
    [DependsOn(
        typeof(HelloEntityFrameworkCoreTestModule)
        )]
    public class HelloDomainTestModule : AbpModule
    {

    }
}