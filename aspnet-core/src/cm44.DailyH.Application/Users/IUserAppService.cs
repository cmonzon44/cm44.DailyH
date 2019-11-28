using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using cm44.DailyH.Roles.Dto;
using cm44.DailyH.Users.Dto;

namespace cm44.DailyH.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
