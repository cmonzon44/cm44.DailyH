using Abp.Authorization;
using cm44.DailyH.Authorization.Roles;
using cm44.DailyH.Authorization.Users;

namespace cm44.DailyH.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
