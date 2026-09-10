using Abp.AutoMapper;
using LowCodePlatformToWms.Sessions.Dto;

namespace LowCodePlatformToWms.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
