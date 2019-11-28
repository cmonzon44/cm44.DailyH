using Abp.MultiTenancy;
using cm44.DailyH.Authorization.Users;

namespace cm44.DailyH.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
