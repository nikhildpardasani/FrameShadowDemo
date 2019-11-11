using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class GridLabelText :Label
    {
        public GridLabelText()
        {
            this.SetDynamicResource(Label.FontFamilyProperty, "DefaultFont");
            this.SetDynamicResource(Label.FontSizeProperty,   "LabelTextFontSize");
            this.SetDynamicResource(Label.TextColorProperty,  "LabelTextColor");
            VerticalTextAlignment = TextAlignment.Center;
            VerticalOptions = LayoutOptions.CenterAndExpand;
        }

        public static BindableProperty IsDisabledProperty =
    BindableProperty.Create(nameof(IsDisabled), typeof(bool), typeof(GridLabelText), default(bool), propertyChanged: IsDisabledPropertyPropertyChanged);

        public bool IsDisabled
        {
            get { return (bool)GetValue(IsDisabledProperty); }
            set { SetValue(IsDisabledProperty, value); }
        }

        private static void IsDisabledPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((bool)newValue)
            {
                GridLabelText label = bindable as GridLabelText;
                label.SetDynamicResource(Label.TextColorProperty, "LabelTextDisabledColor");
            }
            else
            {
                GridLabelText label = bindable as GridLabelText;
                label.SetDynamicResource(Label.TextColorProperty, "LabelInfoColor");
            }
        }
    }
}
