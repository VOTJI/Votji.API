using System.ComponentModel.DataAnnotations;

namespace Votji.API.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}