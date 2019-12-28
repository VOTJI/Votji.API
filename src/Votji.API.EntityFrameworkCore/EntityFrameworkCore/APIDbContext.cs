using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Votji.API.Authorization.Roles;
using Votji.API.Authorization.Users;
using Votji.API.MultiTenancy;
using Votji.API.Blogs;

namespace Votji.API.EntityFrameworkCore
{
    public class APIDbContext : AbpZeroDbContext<Tenant, Role, User, APIDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Blog> Blogs { get; set; }
        public APIDbContext(DbContextOptions<APIDbContext> options)
            : base(options)
        {
        }
    }
}
