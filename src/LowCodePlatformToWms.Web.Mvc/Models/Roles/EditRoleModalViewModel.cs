using Abp.AutoMapper;
using LowCodePlatformToWms.Roles.Dto;
using LowCodePlatformToWms.Web.Models.Common;

namespace LowCodePlatformToWms.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
