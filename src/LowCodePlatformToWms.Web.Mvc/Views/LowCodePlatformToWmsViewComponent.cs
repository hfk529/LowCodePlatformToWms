using Abp.AspNetCore.Mvc.ViewComponents;

namespace LowCodePlatformToWms.Web.Views
{
    public abstract class LowCodePlatformToWmsViewComponent : AbpViewComponent
    {
        protected LowCodePlatformToWmsViewComponent()
        {
            LocalizationSourceName = LowCodePlatformToWmsConsts.LocalizationSourceName;
        }
    }
}
