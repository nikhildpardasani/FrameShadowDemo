using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class LineTemplate : BoxView
    {
        public LineTemplate()
        {
            HorizontalOptions = LayoutOptions.FillAndExpand;
            Margin = new Thickness(15, 0);
            this.SetDynamicResource(BackgroundColorProperty, "LineColor");
            this.SetDynamicResource(HeightRequestProperty, "LineHeight");
        }
    }
}
