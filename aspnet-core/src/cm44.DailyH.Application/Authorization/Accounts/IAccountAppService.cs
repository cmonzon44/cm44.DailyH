using System.Threading.Tasks;
using Abp.Application.Services;
using cm44.DailyH.Authorization.Accounts.Dto;

namespace cm44.DailyH.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
