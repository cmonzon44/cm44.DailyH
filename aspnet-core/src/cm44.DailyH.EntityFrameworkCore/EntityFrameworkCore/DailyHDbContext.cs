using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using cm44.DailyH.Authorization.Roles;
using cm44.DailyH.Authorization.Users;
using cm44.DailyH.MultiTenancy;

namespace cm44.DailyH.EntityFrameworkCore
{
    public class DailyHDbContext : AbpZeroDbContext<Tenant, Role, User, DailyHDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DailyHDbContext(DbContextOptions<DailyHDbContext> options)
            : base(options)
        {
        }
    }
}
