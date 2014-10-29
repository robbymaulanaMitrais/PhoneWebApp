using System.Reflection;
using Abp.Modules;

namespace PhoneWebApp
{
    public class PhoneWebAppCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
