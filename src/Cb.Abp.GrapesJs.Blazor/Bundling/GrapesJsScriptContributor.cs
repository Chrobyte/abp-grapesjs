using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Cb.Abp.GrapesJs.Blazor.Bundling;

public class GrapesJsScriptContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/scripts/grapes-script.js");
        
        context.Files.AddIfNotContains("/libs/grapesjs/js/grapes.min.js");

        // languages
        context.Files.AddIfNotContains("/libs/grapes/locale/ar.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/bs.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/ca.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/de.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/el.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/en.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/fa.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/fr.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/he.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/index.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/it.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/ko.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/nb.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/nl.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/pl.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/pt.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/se.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/tr.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/vi.js");
        context.Files.AddIfNotContains("/libs/grapes/locale/zh.js");

        context.Files.AddIfNotContains("/libs/grapesjs-blocks-basic/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-blocks-basic/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-blocks-basic/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-component-countdown/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-component-countdown/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-component-countdown/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-custom-code/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-custom-code/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-custom-code/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-parser-postcss/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-parser-postcss/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-parser-postcss/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-plugin-export/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-plugin-export/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-plugin-export/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-plugin-forms/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-plugin-forms/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-plugin-forms/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-preset-webpage/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-preset-webpage/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-preset-webpage/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-style-bg/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-style-bg/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-style-bg/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-style-gradient/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-style-gradient/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-style-gradient/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-tabs/grapesjs-tabs.min.js");
        context.Files.AddIfNotContains("/libs/grapesjs-tabs/grapesjs-tabs.min.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-tooltip/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-tooltip/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-tooltip/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-touch/grapesjs-touch.min.js");
        context.Files.AddIfNotContains("/libs/grapesjs-touch/grapesjs-touch.min.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-tui-image-editor/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-tui-image-editor/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-tui-image-editor/index.js.map");

        context.Files.AddIfNotContains("/libs/grapesjs-typed/index.js");
        context.Files.AddIfNotContains("/libs/grapesjs-typed/index.d.js");
        context.Files.AddIfNotContains("/libs/grapesjs-typed/index.js.map");

        context.Files.AddIfNotContains("/libs/grapick/grapick.min.js");
    }
}
