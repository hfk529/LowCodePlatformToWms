using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LowCodePlatformToWms.Configuration;

namespace LowCodePlatformToWms.Web.Host.Startup
{
    [DependsOn(
       typeof(LowCodePlatformToWmsWebCoreModule))]
    public class LowCodePlatformToWmsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LowCodePlatformToWmsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LowCodePlatformToWmsWebHostModule).GetAssembly());
        }
    }
}
