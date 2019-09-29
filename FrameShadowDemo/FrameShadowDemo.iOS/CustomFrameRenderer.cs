using System.ComponentModel;
using System.Diagnostics;
using FrameShadowDemo;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(FrameShadowDemo.iOS.CustomFrameRenderer))]
namespace FrameShadowDemo.iOS
{
    public class CustomFrameRenderer : FrameRenderer
    {
        public static void Initialize() { }
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null) return;
            UpdateShadow();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == "ShadowColor" || e.PropertyName == "Elevation" || e.PropertyName == "LayerBackgroundColor")
            {
                UpdateShadow();
            }
        }

        void UpdateShadow()
        {
            var frame = (CustomFrame)Element;
            Layer.ShadowRadius = frame.Elevation;
            Layer.ShadowColor = frame.ShadowColor.ToCGColor();
            Layer.ShadowOffset = new CoreGraphics.CGSize(0.5, 0.5);
            Layer.ShadowOpacity = 0.5f;
            Layer.MasksToBounds = false;
        }
    }
}
