using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using PhoneWebApp.EntityFramework;

namespace PhoneWebApp
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(PhoneWebAppCoreModule))]
    public class PhoneWebAppDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<PhoneWebAppDbContext>(null);
        }
    }
}
