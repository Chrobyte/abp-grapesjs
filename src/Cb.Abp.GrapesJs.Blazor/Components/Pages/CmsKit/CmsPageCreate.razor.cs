using Blazorise;
using Cb.Abp.GrapesJs.Blazor.Components.CmsKit;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using Volo.CmsKit.Admin.Pages;

namespace Cb.Abp.GrapesJs.Blazor.Components.Pages.CmsKit;

public partial class CmsPageCreate
{
    [Inject]
    public IPageAdminAppService PageAdminAppService { get; set; } = default!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    public CreatePageInputDto Page { get; set; } = new CreatePageInputDto();

    private Validations ValidationsRef = default!;

    private readonly string[] HideIcons = ["bold"];

    private string SelectedTab = "content";

    public MyCmsContentBuilderComponent ContentBuilder { get; set; } = default!;

    protected async Task CreatePageAsync()
    {
        try
        {
            var content = await ContentBuilder.GetGrapesContent();
            Page.Content = content.Html;
            Page.Style = content.Css;

            if (await ValidationsRef.ValidateAll())
            {
                await PageAdminAppService.CreateAsync(Page);
            }
        }
        catch (Exception e)
        {
            await HandleErrorAsync(e);
        }
    }
}
