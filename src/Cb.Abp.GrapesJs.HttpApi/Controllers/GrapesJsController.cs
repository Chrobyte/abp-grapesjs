using Cb.Abp.GrapesJs.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cb.Abp.GrapesJs.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class GrapesJsController : AbpControllerBase
{
    protected GrapesJsController()
    {
        LocalizationResource = typeof(GrapesJsResource);
    }
}
