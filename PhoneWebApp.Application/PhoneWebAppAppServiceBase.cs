using Abp.Application.Services;

namespace PhoneWebApp
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class PhoneWebAppAppServiceBase : ApplicationService
    {
        protected PhoneWebAppAppServiceBase()
        {
            LocalizationSourceName = PhoneWebAppConsts.LocalizationSourceName;
        }
    }
}