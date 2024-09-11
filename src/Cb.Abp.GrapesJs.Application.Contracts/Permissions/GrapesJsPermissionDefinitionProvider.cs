using Cb.Abp.GrapesJs.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Cb.Abp.GrapesJs.Permissions;

public class GrapesJsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GrapesJsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GrapesJsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GrapesJsResource>(name);
    }
}
