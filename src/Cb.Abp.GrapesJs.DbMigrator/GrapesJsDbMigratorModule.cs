using Cb.Abp.GrapesJs.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Cb.Abp.GrapesJs.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(GrapesJsEntityFrameworkCoreModule),
    typeof(GrapesJsApplicationContractsModule)
    )]
public class GrapesJsDbMigratorModule : AbpModule
{
}
