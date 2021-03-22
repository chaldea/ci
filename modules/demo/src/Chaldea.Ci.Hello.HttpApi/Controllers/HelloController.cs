using Chaldea.Ci.Hello.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Chaldea.Ci.Hello.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class HelloController : AbpController
    {
        protected HelloController()
        {
            LocalizationResource = typeof(HelloResource);
        }
    }
}