using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LowCodePlatformToWms.Configuration.Dto;

namespace LowCodePlatformToWms.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LowCodePlatformToWmsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
