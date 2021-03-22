using Chaldea.Ci.Hello.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Chaldea.Ci.Hello.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class HelloPageModel : AbpPageModel
    {
        protected HelloPageModel()
        {
            LocalizationResourceType = typeof(HelloResource);
        }
    }
}