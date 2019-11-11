using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FrameShadowDemo
{
   public class SpacerTemplate :BoxView
    {
        public SpacerTemplate()
        {
           
            HorizontalOptions = LayoutOptions.FillAndExpand;
            HeightRequest = 15;
            Margin = 0;
        }
        public int SpacerHeight { get => (int)GetValue(SpacerHeightProperty); set => SetValue(SpacerHeightProperty, value); }
        public static readonly BindableProperty SpacerHeightProperty = BindableProperty.Create(nameof(SpacerHeight), typeof(int), typeof(SpacerTemplate), 50);

    }
}
