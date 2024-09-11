using Volo.Abp.Modularity;

namespace Cb.Abp.GrapesJs;

/* Inherit from this class for your domain layer tests. */
public abstract class GrapesJsDomainTestBase<TStartupModule> : GrapesJsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
