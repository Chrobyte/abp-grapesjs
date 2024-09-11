using System.Threading.Tasks;
using Cb.Abp.GrapesJs.Localization;
using Cb.Abp.GrapesJs.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace Cb.Abp.GrapesJs.Blazor.Menus;

public class GrapesJsMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<GrapesJsResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                GrapesJsMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 0
            )
        );

        context.Menu.Items.Insert(
            1,
            new ApplicationMenuItem(
                GrapesJsMenus.CmsTest.Create,
                l["Create"],
                "~/my-cms-page-create",
                icon: "fas fa-home",
                order: 0
            )
        );

        context.Menu.Items.Insert(
            2,
            new ApplicationMenuItem(
                GrapesJsMenus.CmsTest.Update,
                l["Update"],
                "~/my-cms-page-update",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 3);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 4);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 5);

        return Task.CompletedTask;
    }
}
