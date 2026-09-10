using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LowCodePlatformToWms.Configuration;
using LowCodePlatformToWms.EntityFrameworkCore;
using LowCodePlatformToWms.Migrator.DependencyInjection;

namespace LowCodePlatformToWms.Migrator
{
    [DependsOn(typeof(LowCodePlatformToWmsEntityFrameworkModule))]
    public class LowCodePlatformToWmsMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public LowCodePlatformToWmsMigratorModule(LowCodePlatformToWmsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(LowCodePlatformToWmsMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                LowCodePlatformToWmsConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LowCodePlatformToWmsMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
