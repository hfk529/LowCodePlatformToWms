using Abp.MultiTenancy;
using LowCodePlatformToWms.Authorization.Users;

namespace LowCodePlatformToWms.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
