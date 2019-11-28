using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using cm44.DailyH.Authorization.Users;
using cm44.DailyH.Editions;

namespace cm44.DailyH.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
