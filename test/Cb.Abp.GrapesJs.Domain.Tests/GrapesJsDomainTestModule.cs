using Volo.Abp.Modularity;

namespace Cb.Abp.GrapesJs;

[DependsOn(
    typeof(GrapesJsDomainModule),
    typeof(GrapesJsTestBaseModule)
)]
public class GrapesJsDomainTestModule : AbpModule
{

}
