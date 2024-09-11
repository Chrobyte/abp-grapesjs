using Volo.Abp.Modularity;

namespace Cb.Abp.GrapesJs;

[DependsOn(
    typeof(GrapesJsApplicationModule),
    typeof(GrapesJsDomainTestModule)
)]
public class GrapesJsApplicationTestModule : AbpModule
{

}
