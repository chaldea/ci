using System;
using System.Collections.Generic;
using System.Text;
using Chaldea.Ci.Hello.Localization;
using Volo.Abp.Application.Services;

namespace Chaldea.Ci.Hello
{
    /* Inherit your application services from this class.
     */
    public abstract class HelloAppService : ApplicationService
    {
        protected HelloAppService()
        {
            LocalizationResource = typeof(HelloResource);
        }
    }
}
