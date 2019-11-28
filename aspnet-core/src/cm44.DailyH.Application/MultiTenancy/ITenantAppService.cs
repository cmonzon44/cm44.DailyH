using Abp.Application.Services;
using Abp.Application.Services.Dto;
using cm44.DailyH.MultiTenancy.Dto;

namespace cm44.DailyH.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

