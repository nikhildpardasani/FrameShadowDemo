using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class GButton : Xamarin.Forms.Button
    {
        public GButton()
        {
            this.BorderWidth = 0.5;
            this.Clicked += ChangeTheColours;
            this.HorizontalOptions = LayoutOptions.Center;
            this.SetDynamicResource(BackgroundColorProperty, "GridDButtonBackgroundColor");
            this.SetDynamicResource(BorderColorProperty,     "GridDButtonBorderColor");
            this.SetDynamicResource(CornerRadiusProperty,    "GridButtonCornerRadius");
            this.SetDynamicResource(FontFamilyProperty,      "DefaultFont");
            this.SetDynamicResource(FontSizeProperty,        "GridButtonFontSize");
            this.SetDynamicResource(HeightRequestProperty,   "GridButtonHeightRequest");
            this.SetDynamicResource(PaddingProperty,         "GridButtonPadding");
            this.SetDynamicResource(TextColorProperty,       "GridDButtonTextColor");
            this.VerticalOptions = LayoutOptions.Center;
            
        }
        public static readonly BindableProperty StateProperty =
            BindableProperty.Create(nameof(State), typeof(string),
                typeof(GButton), "D", propertyChanged: HandleStatePropertyChanged);

        public string State
        {
            get => (string)GetValue(StateProperty);
            set => SetValue(StateProperty, value);
        }

        private static void HandleStatePropertyChanged(BindableObject bindable, object oldValue, object state)
        {
            var control = (GButton)bindable;
            if (control != null)
                ConfigureColors(control, (string)state);
        }

        private async void ChangeTheColours(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
                return;

            try
            {
                ConfigureColors((GButton)sender, "C");
                await Task.Delay(200);
                ConfigureColors((GButton)sender, State);
            }
#pragma warning disable RECS0022 // A catch clause that catches System.Exception and has an empty body
            catch (Exception)
#pragma warning restore RECS0022 // A catch clause that catches System.Exception and has an empty body
            {

            }
        }
        private static void ConfigureColors(GButton control, string state)
        {
            if (state == null) state = "D";
            switch (state)
            {
                case "D":
                    control.SetDynamicResource(BorderColorProperty, "GridDButtonBorderColor");
                    control.SetDynamicResource(BackgroundColorProperty, "GridDButtonBackgroundColor");
                    control.SetDynamicResource(TextColorProperty, "GridDButtonTextColor");
                    break;
                case "C":
                    control.SetDynamicResource(BorderColorProperty, "GridCButtonBorderColor");
                    control.SetDynamicResource(BackgroundColorProperty, "GridCButtonBackgroundColor");
                    control.SetDynamicResource(TextColorProperty, "GridCButtonTextColor");
                    break;
                case "E":
                    control.SetDynamicResource(BorderColorProperty, "GridEButtonBorderColor");
                    control.SetDynamicResource(BackgroundColorProperty, "GridEButtonBackgroundColor");
                    control.SetDynamicResource(TextColorProperty, "GridEButtonTextColor");
                    break;
                default: throw new Exception("Unhandled value: " + state);
            }
        }
    }
}