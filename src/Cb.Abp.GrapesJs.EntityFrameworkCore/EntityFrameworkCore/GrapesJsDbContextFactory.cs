using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Cb.Abp.GrapesJs.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class GrapesJsDbContextFactory : IDesignTimeDbContextFactory<GrapesJsDbContext>
{
    public GrapesJsDbContext CreateDbContext(string[] args)
    {
        GrapesJsEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<GrapesJsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new GrapesJsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Cb.Abp.GrapesJs.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
