using Blazorise;
using Cb.Abp.GrapesJs.Blazor.Components.CmsKit;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using Volo.Abp.ObjectExtending;
using Volo.CmsKit.Admin.Pages;

namespace Cb.Abp.GrapesJs.Blazor.Components.Pages.CmsKit;

public partial class CmsPageUpdate
{
    [Parameter]
    public Guid Id { get; set; }

    [Inject]
    public IPageAdminAppService PageAdminAppService { get; set; } = default!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    public UpdatePageInputDto EditingPage { get; set; } = default!;

    private Validations ValidationsRef = default!;

    private readonly string[] HideIcons = ["bold"];

    private string SelectedTab = "content";

    public MyCmsContentBuilderComponent ContentBuilder { get; set; } = default!;

    protected async override Task OnInitializedAsync()
    {
        await GetEditingPageAsync();
    }

    protected virtual async Task GetEditingPageAsync()
    {
        var page = await PageAdminAppService.GetAsync(Id);

        EditingPage = new UpdatePageInputDto
        {
            ConcurrencyStamp = page.ConcurrencyStamp,
            Content = page.Content,
            Script = page.Script,
            Style = page.Style,
            Title = page.Title,
            Slug = page.Slug
        };
        page.MapExtraPropertiesTo(EditingPage);
    }

    protected virtual async Task UpdatePageAsync()
    {
        try
        {
            var content = await ContentBuilder.GetGrapesContent();
            EditingPage.Content = content.Html;
            EditingPage.Style = content.Css;

            if (await ValidationsRef.ValidateAll())
            {
                await PageAdminAppService.UpdateAsync(Id, EditingPage);
            }
        }
        catch (Exception e)
        {
            await HandleErrorAsync(e);
        }
    }
}
