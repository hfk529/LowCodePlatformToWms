using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using LowCodePlatformToWms.EntityFrameworkCore.Seed;

namespace LowCodePlatformToWms.EntityFrameworkCore
{
    [DependsOn(
        typeof(LowCodePlatformToWmsCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class LowCodePlatformToWmsEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<LowCodePlatformToWmsDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        LowCodePlatformToWmsDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        LowCodePlatformToWmsDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LowCodePlatformToWmsEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
