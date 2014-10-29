using Abp.Web.Mvc.Controllers;

namespace PhoneWebApp.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class PhoneWebAppControllerBase : AbpController
    {
        protected PhoneWebAppControllerBase()
        {
            LocalizationSourceName = PhoneWebAppConsts.LocalizationSourceName;
        }
    }
}