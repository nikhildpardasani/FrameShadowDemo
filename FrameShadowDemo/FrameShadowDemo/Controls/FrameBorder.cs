using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class FrameBorder : CustomFrame
    {
        public FrameBorder()
        {
            this.Margin = new Thickness(15, 0);
            this.SetDynamicResource(BackgroundColorProperty, "FrameBackgroundColor");
            this.SetDynamicResource(CornerRadiusProperty, "FrameCornerRadius");
            this.SetDynamicResource(ElevationProperty, "FrameElevation");
            this.SetDynamicResource(PaddingProperty, "FrameBorderPadding");
            this.SetDynamicResource(ShadowColorProperty, "FrameShadowColor");
            this.SetDynamicResource(MarginProperty, "FrameMargin");
            this.VerticalOptions = LayoutOptions.FillAndExpand;
        }
    }
}
