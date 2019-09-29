using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class CustomFrame : Frame
    {
        public static BindableProperty ElevationProperty =
            BindableProperty.Create(nameof(Elevation), typeof(float), typeof(CustomFrame), 1.0f);

        public float Elevation
        {
            get { return (float)GetValue(ElevationProperty); }
            set { SetValue(ElevationProperty, value); }
        }

        public static BindableProperty ShadowColorProperty =
            BindableProperty.Create(nameof(ShadowColor), typeof(Color), typeof(CustomFrame));
        public Color ShadowColor
        {
            get { return (Color)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }
    }
}
