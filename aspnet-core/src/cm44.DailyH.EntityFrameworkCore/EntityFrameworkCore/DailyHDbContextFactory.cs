using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using cm44.DailyH.Configuration;
using cm44.DailyH.Web;

namespace cm44.DailyH.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DailyHDbContextFactory : IDesignTimeDbContextFactory<DailyHDbContext>
    {
        public DailyHDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DailyHDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DailyHDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DailyHConsts.ConnectionStringName));

            return new DailyHDbContext(builder.Options);
        }
    }
}
