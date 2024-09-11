using Blazorise.Markdown;
using Blazorise;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
using Volo.Abp.Content;
using Volo.Abp;
using Volo.CmsKit.Admin.MediaDescriptors;
using Volo.CmsKit.Blogs;
using Volo.CmsKit.Contents;
using Volo.CmsKit.Web.Contents;
using Volo.CmsKit.Web.Pages.CmsKit.Components.Contents;
using System.Linq;
using Volo.CmsKit.Admin.Contents;

namespace Cb.Abp.GrapesJs.Blazor.Components.CmsKit;

public partial class MyCmsContentBuilderComponent
{
    [Inject]
    protected IJSRuntime JsRuntime { get; set; } = default!;

    [Parameter]
    public string Value { get; set; } = default!;

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    [Parameter]
    public string Css { get; set; } = default!;

    [Parameter]
    public EventCallback<string> CssChanged { get; set; }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JsRuntime.InvokeVoidAsync("initializeGrapes", "gjs");

            await JsRuntime.InvokeVoidAsync("setGrapesContent", Value ?? string.Empty, Css ?? string.Empty);
        }
    }

    protected virtual Task OnValueChanged(string value)
    {
        Value = value;
        ValueChanged.InvokeAsync(value);
        return Task.CompletedTask;
    }

    public async Task<GrapesContent> GetGrapesContent()
    {
        var content = await JsRuntime.InvokeAsync<GrapesContent>("getGrapesContent");
        return content;
    }

    public class GrapesContent
    {
        public string Html { get; set; } = default!;
        public string Css { get; set; } = default!;
    }
}
