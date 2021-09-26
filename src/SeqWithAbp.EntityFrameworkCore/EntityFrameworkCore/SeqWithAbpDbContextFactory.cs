using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SeqWithAbp.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class SeqWithAbpDbContextFactory : IDesignTimeDbContextFactory<SeqWithAbpDbContext>
    {
        public SeqWithAbpDbContext CreateDbContext(string[] args)
        {
            SeqWithAbpEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SeqWithAbpDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new SeqWithAbpDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SeqWithAbp.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
