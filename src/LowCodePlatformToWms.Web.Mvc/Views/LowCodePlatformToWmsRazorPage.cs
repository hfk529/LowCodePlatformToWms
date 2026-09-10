using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LowCodePlatformToWms.Web.Views
{
    public abstract class LowCodePlatformToWmsRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LowCodePlatformToWmsRazorPage()
        {
            LocalizationSourceName = LowCodePlatformToWmsConsts.LocalizationSourceName;
        }
    }
}
