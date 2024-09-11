using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Cb.Abp.GrapesJs.Data;

/* This is used if database provider does't define
 * IGrapesJsDbSchemaMigrator implementation.
 */
public class NullGrapesJsDbSchemaMigrator : IGrapesJsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
