using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LowCodePlatformToWms.EntityFrameworkCore;
using LowCodePlatformToWms.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LowCodePlatformToWms.Web.Tests
{
    [DependsOn(
        typeof(LowCodePlatformToWmsWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LowCodePlatformToWmsWebTestModule : AbpModule
    {
        public LowCodePlatformToWmsWebTestModule(LowCodePlatformToWmsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LowCodePlatformToWmsWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LowCodePlatformToWmsWebMvcModule).Assembly);
        }
    }
}