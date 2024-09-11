using System.Threading.Tasks;

namespace Cb.Abp.GrapesJs.Data;

public interface IGrapesJsDbSchemaMigrator
{
    Task MigrateAsync();
}
