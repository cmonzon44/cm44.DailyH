using System.ComponentModel.DataAnnotations;

namespace cm44.DailyH.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}