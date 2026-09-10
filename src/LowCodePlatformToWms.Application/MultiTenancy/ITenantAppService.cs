using Abp.Application.Services;
using LowCodePlatformToWms.MultiTenancy.Dto;

namespace LowCodePlatformToWms.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

