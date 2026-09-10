using System.Collections.Generic;
using LowCodePlatformToWms.Roles.Dto;

namespace LowCodePlatformToWms.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
