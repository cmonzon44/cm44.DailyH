using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace cm44.DailyH.Controllers
{
    public abstract class DailyHControllerBase: AbpController
    {
        protected DailyHControllerBase()
        {
            LocalizationSourceName = DailyHConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
