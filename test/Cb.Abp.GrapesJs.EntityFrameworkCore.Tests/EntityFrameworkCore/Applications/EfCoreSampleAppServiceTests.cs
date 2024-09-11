using Cb.Abp.GrapesJs.Samples;
using Xunit;

namespace Cb.Abp.GrapesJs.EntityFrameworkCore.Applications;

[Collection(GrapesJsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<GrapesJsEntityFrameworkCoreTestModule>
{

}
