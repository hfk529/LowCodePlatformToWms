using Abp.Application.Services.Dto;

namespace LowCodePlatformToWms.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

