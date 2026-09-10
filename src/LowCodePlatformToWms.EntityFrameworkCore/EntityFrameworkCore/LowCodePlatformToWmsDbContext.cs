using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LowCodePlatformToWms.Authorization.Roles;
using LowCodePlatformToWms.Authorization.Users;
using LowCodePlatformToWms.MultiTenancy;

namespace LowCodePlatformToWms.EntityFrameworkCore
{
    public class LowCodePlatformToWmsDbContext : AbpZeroDbContext<Tenant, Role, User, LowCodePlatformToWmsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LowCodePlatformToWmsDbContext(DbContextOptions<LowCodePlatformToWmsDbContext> options)
            : base(options)
        {
        }
    }
}
