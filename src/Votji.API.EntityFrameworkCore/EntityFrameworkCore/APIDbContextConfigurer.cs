using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Votji.API.EntityFrameworkCore
{
    public static class APIDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<APIDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<APIDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
