using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LowCodePlatformToWms.Localization
{
    public static class LowCodePlatformToWmsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LowCodePlatformToWmsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LowCodePlatformToWmsLocalizationConfigurer).GetAssembly(),
                        "LowCodePlatformToWms.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
