using System.Collections.Generic;
using LowCodePlatformToWms.Roles.Dto;

namespace LowCodePlatformToWms.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}