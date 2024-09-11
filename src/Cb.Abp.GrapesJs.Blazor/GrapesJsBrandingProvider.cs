using Microsoft.Extensions.Localization;
using Cb.Abp.GrapesJs.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Cb.Abp.GrapesJs.Blazor;

[Dependency(ReplaceServices = true)]
public class GrapesJsBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<GrapesJsResource> _localizer;

    public GrapesJsBrandingProvider(IStringLocalizer<GrapesJsResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
