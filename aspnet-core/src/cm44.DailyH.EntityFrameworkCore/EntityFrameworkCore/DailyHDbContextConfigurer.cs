using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace cm44.DailyH.EntityFrameworkCore
{
    public static class DailyHDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DailyHDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DailyHDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
