using System.Threading.Tasks;
using Abp.Application.Services;
using LowCodePlatformToWms.Authorization.Accounts.Dto;

namespace LowCodePlatformToWms.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
