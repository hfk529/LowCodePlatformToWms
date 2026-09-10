using System.Collections.Generic;
using LowCodePlatformToWms.Roles.Dto;

namespace LowCodePlatformToWms.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
