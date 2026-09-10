using System.Threading.Tasks;
using Abp.Application.Services;
using LowCodePlatformToWms.Sessions.Dto;

namespace LowCodePlatformToWms.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
