using LowCodePlatformToWms.Debugging;

namespace LowCodePlatformToWms
{
    public class LowCodePlatformToWmsConsts
    {
        public const string LocalizationSourceName = "LowCodePlatformToWms";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7b9df3d8aa804f7994d147060adf0fc6";
    }
}
