using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class InfoTemplate : Label
    {
        public InfoTemplate()
        {
            this.SetDynamicResource(FontFamilyProperty, "DefaultFont");
            this.SetDynamicResource(FontSizeProperty, "InfoTextFontSize");
            this.SetDynamicResource(MarginProperty, "InfoMargin");
            this.SetDynamicResource(TextColorProperty, "LabelInfoColor");
        }
    }
}
