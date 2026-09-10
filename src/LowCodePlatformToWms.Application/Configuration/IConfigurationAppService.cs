using System.Threading.Tasks;
using LowCodePlatformToWms.Configuration.Dto;

namespace LowCodePlatformToWms.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
