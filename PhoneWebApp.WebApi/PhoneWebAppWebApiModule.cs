using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace PhoneWebApp
{
    [DependsOn(typeof(AbpWebApiModule), typeof(PhoneWebAppApplicationModule))]
    public class PhoneWebAppWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(PhoneWebAppApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
