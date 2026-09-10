using Abp.Authorization;
using LowCodePlatformToWms.Authorization.Roles;
using LowCodePlatformToWms.Authorization.Users;

namespace LowCodePlatformToWms.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
