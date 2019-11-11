using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class GridLabelLink : Label
    {
        public GridLabelLink()
        {
            this.SetDynamicResource(Label.FontFamilyProperty, "DefaultFont");
            this.SetDynamicResource(Label.FontSizeProperty,   "LabelTextFontSize");
            this.SetDynamicResource(Label.TextColorProperty,  "LabelLinkColor");
            VerticalTextAlignment = TextAlignment.Center;
            VerticalOptions = LayoutOptions.CenterAndExpand;
        }

        public static BindableProperty IsDisabledProperty =
    BindableProperty.Create(nameof(IsDisabled), typeof(bool), typeof(GridLabelLink), default(bool), propertyChanged: IsDisabledPropertyPropertyChanged);

        public bool IsDisabled
        {
            get { return (bool)GetValue(IsDisabledProperty); }
            set { SetValue(IsDisabledProperty, value); }
        }

        private static void IsDisabledPropertyPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if ((bool)newValue)
            {
                GridLabelLink label = bindable as GridLabelLink;
                label.SetDynamicResource(Label.TextColorProperty, "LabelLinkDisabledColor");
            }
            else
            {
                GridLabelLink label = bindable as GridLabelLink;
                label.SetDynamicResource(Label.TextColorProperty, "LabelLinkColor");
            }
        }
    }
}
