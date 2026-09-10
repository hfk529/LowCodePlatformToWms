using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LowCodePlatformToWms.Authorization;

namespace LowCodePlatformToWms
{
    [DependsOn(
        typeof(LowCodePlatformToWmsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LowCodePlatformToWmsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LowCodePlatformToWmsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LowCodePlatformToWmsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
