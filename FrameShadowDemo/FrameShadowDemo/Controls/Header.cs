using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class HeaderTemplate :Label
    {
        public HeaderTemplate()
        {
            this.SetDynamicResource(Label.FontSizeProperty,   "HeaderTextFontSize");
            this.SetDynamicResource(Label.FontFamilyProperty, "SemiBoldFont");
            this.SetDynamicResource(View.MarginProperty,      "HeaderMargin");
            this.SetDynamicResource(Label.TextColorProperty,  "HeaderTextColor");
            HorizontalOptions = LayoutOptions.FillAndExpand;
            FontAttributes = FontAttributes.Bold;
            this.Header = this.Text;
        }
        public static readonly BindableProperty HeaderProperty = BindableProperty.Create(nameof(Header), typeof(string), typeof(HeaderTemplate), default(string));
        public string Header { get => (string)GetValue(HeaderProperty); set => SetValue(HeaderProperty, value); }
    }
}
