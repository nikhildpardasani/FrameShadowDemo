using Xamarin.Forms;


namespace FrameShadowDemo
{
    public partial class App : Application
    {

        public static void SetResourceColors(int value = 0)
        {
            var thc = value;

            // Lines
            Current.Resources["LineColor"]              = Styles.LineColor[thc];

            // Page
            Current.Resources["PageTitleTextColor"]     = Styles.PageTitleTextColor[thc];

            // Frame
            Current.Resources["FrameBackgroundColor"]   = Styles.FrameBackgroundColor[thc];
            Current.Resources["FrameBorderColor"]       = Styles.FrameBorderColor[thc];
            Current.Resources["FrameShadowColor"]       = Styles.FrameShadowColor[thc];

            // Text 
            Current.Resources["HeaderTextColor"]        = Styles.HeaderTextColor[thc];
            Current.Resources["LabelInfoColor"]         = Styles.LabelInfoColor[thc];
            Current.Resources["LabelLinkColor"]         = Styles.LabelLinkColor[thc];
            Current.Resources["LabelTextColor"]         = Styles.LabelTextColor[thc];
            Current.Resources["LabelTickColor"]         = Styles.LabelTickColor[thc];
            Current.Resources["SubHeaderTextColor"]     = Styles.SubHeaderTextColor[thc];

            Current.Resources["PageBackgroundColor"]    = Styles.PageBackgroundColor[thc];
            Current.Resources["WordBackgroundColor"]    = Styles.WordBackgroundColor[thc];
            Current.Resources["WordTextColor"]          = Styles.WordTextColor[thc];

            // Grid
            Current.Resources["GridDButtonTextColor"] = Styles.GridDButtonTextColor[thc];
            Current.Resources["GridCButtonTextColor"] = Styles.GridCButtonTextColor[thc];
            Current.Resources["GridEButtonTextColor"] = Styles.GridEButtonTextColor[thc];
            Current.Resources["GridDButtonBorderColor"] = Styles.GridDButtonBorderColor[thc];
            Current.Resources["GridCButtonBorderColor"] = Styles.GridCButtonBorderColor[thc];
            Current.Resources["GridEButtonBorderColor"] = Styles.GridEButtonBorderColor[thc];
            Current.Resources["GridDButtonBackgroundColor"] = Styles.GridDButtonBackgroundColor[thc];
            Current.Resources["GridCButtonBackgroundColor"] = Styles.GridCButtonBackgroundColor[thc];
            Current.Resources["GridEButtonBackgroundColor"] = Styles.GridEButtonBackgroundColor[thc];
            Current.Resources["GridTappedColor"] = Styles.GridTappedColor[thc];

            // Page
            Current.Resources["PageDButtonTextColor"] = Styles.PageDButtonTextColor[thc];
            Current.Resources["PageCButtonTextColor"] = Styles.PageCButtonTextColor[thc];
            Current.Resources["PageEButtonTextColor"] = Styles.PageEButtonTextColor[thc];
            Current.Resources["PageDButtonBorderColor"] = Styles.PageDButtonBorderColor[thc];
            Current.Resources["PageCButtonBorderColor"] = Styles.PageCButtonBorderColor[thc];
            Current.Resources["PageEButtonBorderColor"] = Styles.PageEButtonBorderColor[thc];
            Current.Resources["PageDButtonBackgroundColor"] = Styles.PageDButtonBackgroundColor[thc];
            Current.Resources["PageCButtonBackgroundColor"] = Styles.PageCButtonBackgroundColor[thc];
            Current.Resources["PageEButtonBackgroundColor"] = Styles.PageEButtonBackgroundColor[thc];

            // TabBar
            Current.Resources["TabBarBackgroundColor"]  = Styles.TabBarBackgroundColor[thc];
            Current.Resources["TabBarDisabledColor"]    = Styles.TabBarDisabledColor[thc];
            Current.Resources["TabBarForegroundColor"]  = Styles.TabBarForegroundColor[thc];
            Current.Resources["TabBarTitleColor"]       = Styles.TabBarTitleColor[thc];
            Current.Resources["TabBarUnselectedColor"]  = Styles.TabBarUnselectedColor[thc];
            Current.Resources["ShellForegroundColor"]   = Styles.ShellForegroundColor[thc];
            Current.Resources["ShellBackgroundColor"]   = Styles.ShellBackgroundColor[thc];
            Current.Resources["ShellTitleColor"]        = Styles.ShellTitleColor[thc];
            Current.Resources["ShellUnselectedColor"]   = Styles.ShellUnselectedColor[thc];
        }
    }
}
