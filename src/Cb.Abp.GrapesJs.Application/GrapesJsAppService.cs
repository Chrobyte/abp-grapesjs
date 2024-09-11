using System;
using System.Collections.Generic;
using System.Text;
using Cb.Abp.GrapesJs.Localization;
using Volo.Abp.Application.Services;

namespace Cb.Abp.GrapesJs;

/* Inherit your application services from this class.
 */
public abstract class GrapesJsAppService : ApplicationService
{
    protected GrapesJsAppService()
    {
        LocalizationResource = typeof(GrapesJsResource);
    }
}
