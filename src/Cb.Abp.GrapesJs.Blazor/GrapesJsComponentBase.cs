using Cb.Abp.GrapesJs.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Cb.Abp.GrapesJs.Blazor;

public abstract class GrapesJsComponentBase : AbpComponentBase
{
    protected GrapesJsComponentBase()
    {
        LocalizationResource = typeof(GrapesJsResource);
    }
}
