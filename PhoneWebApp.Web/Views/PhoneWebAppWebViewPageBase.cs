using Abp.Web.Mvc.Views;

namespace PhoneWebApp.Web.Views
{
    public abstract class PhoneWebAppWebViewPageBase : PhoneWebAppWebViewPageBase<dynamic>
    {

    }

    public abstract class PhoneWebAppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected PhoneWebAppWebViewPageBase()
        {
            LocalizationSourceName = PhoneWebAppConsts.LocalizationSourceName;
        }
    }
}