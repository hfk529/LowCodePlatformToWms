using System.ComponentModel.DataAnnotations;

namespace LowCodePlatformToWms.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}