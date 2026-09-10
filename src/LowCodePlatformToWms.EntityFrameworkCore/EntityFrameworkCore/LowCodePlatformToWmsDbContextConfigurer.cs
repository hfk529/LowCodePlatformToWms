using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LowCodePlatformToWms.EntityFrameworkCore
{
    public static class LowCodePlatformToWmsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LowCodePlatformToWmsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LowCodePlatformToWmsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
