using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LowCodePlatformToWms.Controllers
{
    public abstract class LowCodePlatformToWmsControllerBase: AbpController
    {
        protected LowCodePlatformToWmsControllerBase()
        {
            LocalizationSourceName = LowCodePlatformToWmsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
