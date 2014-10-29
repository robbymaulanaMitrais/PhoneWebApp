using System.Reflection;
using Abp.Modules;

namespace PhoneWebApp
{
    [DependsOn(typeof(PhoneWebAppCoreModule))]
    public class PhoneWebAppApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
