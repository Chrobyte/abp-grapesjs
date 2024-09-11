using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Cb.Abp.GrapesJs.Blazor.Bundling;

public class GrapesJsStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/libs/grapesjs/css/grapes.min.css");
        context.Files.AddIfNotContains("/libs/grapick/grapick.min.css");
    }
}
