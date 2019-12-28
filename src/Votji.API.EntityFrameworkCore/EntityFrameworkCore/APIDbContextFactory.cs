using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Votji.API.Configuration;
using Votji.API.Web;

namespace Votji.API.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class APIDbContextFactory : IDesignTimeDbContextFactory<APIDbContext>
    {
        public APIDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<APIDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            APIDbContextConfigurer.Configure(builder, configuration.GetConnectionString(APIConsts.ConnectionStringName));

            return new APIDbContext(builder.Options);
        }
    }
}
