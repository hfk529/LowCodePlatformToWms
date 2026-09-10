using System.Collections.Generic;

namespace LowCodePlatformToWms.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
