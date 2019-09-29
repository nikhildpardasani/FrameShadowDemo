using Xamarin.Forms;

namespace FrameShadowDemo
{
    public  class WordFrame :  CustomFrame
    {
        public WordFrame()
        {
            this.SetDynamicResource(BackgroundColorProperty, "WordBackgroundColor");
            this.Margin = new Thickness(15, 0);
            this.SetDynamicResource(ElevationProperty, "FrameElevation");
            this.SetDynamicResource(CornerRadiusProperty, "FrameCornerRadius");
            this.SetDynamicResource(PaddingProperty, "FrameBorderPadding");
            this.SetDynamicResource(ShadowColorProperty, "FrameShadowColor");
            this.VerticalOptions = LayoutOptions.FillAndExpand;
        }
    }
}