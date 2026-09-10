using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LowCodePlatformToWms.Configuration;

namespace LowCodePlatformToWms.Web.Startup
{
    [DependsOn(typeof(LowCodePlatformToWmsWebCoreModule))]
    public class LowCodePlatformToWmsWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LowCodePlatformToWmsWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<LowCodePlatformToWmsNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LowCodePlatformToWmsWebMvcModule).GetAssembly());
        }
    }
}
