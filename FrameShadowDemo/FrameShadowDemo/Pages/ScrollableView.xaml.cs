using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace FrameShadowDemo
{
    [ContentProperty(nameof(InnerContent))]
    public partial class ScrollableView : ContentPage
    {
        private bool openedOnce = false;
        public static readonly BindableProperty InnerContentProperty = BindableProperty.Create(nameof(InnerContent), typeof(View), typeof(ContentPage));

        public View InnerContent
        {
            get => (View)this.GetValue(InnerContentProperty);
            set => this.SetValue(InnerContentProperty, value);
        }

        public static readonly BindableProperty PageTitleProperty = BindableProperty.Create(nameof(PageTitle), typeof(string), typeof(ScrollableView), default(string));
        public string PageTitle { get => (string)GetValue(PageTitleProperty); set => SetValue(PageTitleProperty, value); }

        public ScrollableView()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!openedOnce)
            {
                scroll.ScrollToAsync(0, 0, false);
                openedOnce = true;
            }
            var safeInsets = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            // safeInsets.Left = 24;
            // this.Padding = new Thickness(0,0,0,0);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

    }
}
