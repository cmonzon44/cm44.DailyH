using System.Threading.Tasks;
using Abp.Application.Services;
using cm44.DailyH.Sessions.Dto;

namespace cm44.DailyH.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
