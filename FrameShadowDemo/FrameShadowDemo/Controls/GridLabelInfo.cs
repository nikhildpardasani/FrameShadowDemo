using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class GridLabelInfo : Label
    {
        public GridLabelInfo()
        {
            this.SetDynamicResource(Label.FontFamilyProperty, "DefaultFont");
            this.SetDynamicResource(Label.FontSizeProperty,   "LabelTextFontSize");
            this.SetDynamicResource(Label.TextColorProperty,  "LabelInfoColor");
            VerticalTextAlignment = TextAlignment.Center;
            VerticalOptions = LayoutOptions.CenterAndExpand;
        }

        public static BindableProperty IsDisabledProperty =
    BindableProperty.Create(nameof(IsDisabled), typeof(bool), typeof(GridLabelInfo), default(bool), propertyChanged: IsDisabledPropertyPropertyChanged);

        public bool IsDisabled
        {
            get { return (bool)GetValue(IsDisabledProperty); }
            set { SetValue(IsDisabledProperty, value); }
        }

        private static void IsDisabledPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((bool)newValue)
            {
                GridLabelInfo label = bindable as GridLabelInfo;
                label.SetDynamicResource(Label.TextColorProperty, "LabelTextDisabledColor");
            }
            else
            {
                GridLabelInfo label = bindable as GridLabelInfo;
                label.SetDynamicResource(Label.TextColorProperty, "LabelInfoColor");
            }
        }
    }
}
