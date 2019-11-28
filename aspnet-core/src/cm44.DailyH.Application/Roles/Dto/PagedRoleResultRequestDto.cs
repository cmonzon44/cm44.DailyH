using Abp.Application.Services.Dto;

namespace cm44.DailyH.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

