using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cb.Abp.GrapesJs.Data;
using Volo.Abp.DependencyInjection;

namespace Cb.Abp.GrapesJs.EntityFrameworkCore;

public class EntityFrameworkCoreGrapesJsDbSchemaMigrator
    : IGrapesJsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreGrapesJsDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the GrapesJsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<GrapesJsDbContext>()
            .Database
            .MigrateAsync();
    }
}
