using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace FrameShadowDemo
{
    [ContentProperty(nameof(InnerContent))]
    public partial class BackArrowScrollableView : ContentPage
    {
        private bool openedOnce = false;
        public static readonly BindableProperty InnerContentProperty = BindableProperty.Create(nameof(InnerContent), typeof(View), typeof(ContentPage));

        public View InnerContent
        {
            get => (View)this.GetValue(InnerContentProperty);
            set => this.SetValue(InnerContentProperty, value);
        }

        public static readonly BindableProperty BackPageTitleProperty = BindableProperty.Create(nameof(BackPageTitle), typeof(string), typeof(ScrollableView), default(string));
        public string BackPageTitle { get => (string)GetValue(BackPageTitleProperty); set => SetValue(BackPageTitleProperty, value); }

        public static readonly BindableProperty PageTitleProperty = BindableProperty.Create(nameof(PageTitle), typeof(string), typeof(ScrollableView), default(string));
        public string PageTitle { get => (string)GetValue(PageTitleProperty); set => SetValue(PageTitleProperty, value); }

        public BackArrowScrollableView()
        {
            InitializeComponent();
            BindingContext = this;
            tap.Tapped += MyTappedHandler;
            scroll.Scrolled += Scroll_Scrolled;
        }

        private void Scroll_Scrolled(object sender, ScrolledEventArgs e)
        {

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

        protected void MyTappedHandler(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PopAsync();

        }

    }
}
