namespace Cb.Abp.GrapesJs.Blazor.Menus;

public class GrapesJsMenus
{
    private const string Prefix = "GrapesJs";
    public const string Home = Prefix + ".Home";

    //Add your menu items here...

    public class CmsTest
    {
        private const string _myPrefix = Prefix + ".CmsTest";

        public const string Create = _myPrefix + ".Create";
        public const string Update = _myPrefix + ".Update";
    }
}
