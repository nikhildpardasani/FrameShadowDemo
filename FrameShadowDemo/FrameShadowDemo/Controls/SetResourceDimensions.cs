using Xamarin.Forms;
using System.Diagnostics;
using Xamarin.Essentials;

namespace FrameShadowDemo
{
    public partial class App : Application
    {

        public static void SetResourceDimensions()
        {
            // https://developer.apple.com/library/archive/documentation/DeviceInformation/Reference/iOSDeviceCompatibility/Displays/Displays.html

            // Device
            // Native Resolution(Pixels)
            // UIKit Size(Points)
            // Native Scale factor
            // UIKit Scale factor

            // XR & XsMax                                 414 x  896
            // iPhone Xs                                  375 x  812 
            // iPhone X                      1125 x 2436  375 x  812   3.0     3.0
            // iPhone 8 Plus                 1080 x 1920  414 x  736   2.608   3.0
            // iPhone 8                      750 x 1334   375 x  667   2.0     2.0
            // iPhone 7 Plus                 1080 x 1920  414 x  736   2.608   3.0
            // iPhone 6s Plus                1080 x 1920  375 x  667   2.608   3.0
            // iPhone 6 Plus                 1080 x 1920  375 x  667   2.608   3.0
            // iPhone 7                       750 x 1334  375 x  667   2.0     2.0
            // iPhone 6s                      750 x 1334  375 x  667   2.0     2.0
            // iPhone 6                       750 x 1334  375 x  667   2.0     2.0
            // iPhone SE                      640 x 1136  320 x  568   2.0     2.0
            // iPhone 5,5s,5c                 640 x 1136  320 x  568   2.0     2.0
            // iPad Pro 12.9 - inch(2nd gen) 2048 x 2732 1024 x 1366   2.0     2.0
            // iPad Pro 10.5 - inch          2224 x 1668 1112 x  834   2.0     2.0
            // iPad Pro(12.9 - inch)         2048 x 2732 1024 x 1366   2.0     2.0
            // iPad Pro(9.7 - inch)          1536 x 2048  768 x 1024   2.0     2.0
            // iPad Air 2                    1536 x 2048  768 x 1024   2.0     2.0
            // iPad Mini 4                   1536 x 2048  768 x 1024   2.0     2.0

            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            var density = mainDisplayInfo.Density;
            var width = (int)(mainDisplayInfo.Width / density);
            var height = (int)(mainDisplayInfo.Height / density);

            bool devIsIOS = Device.RuntimePlatform == Device.iOS;
            bool isLandscape = mainDisplayInfo.Orientation == DisplayOrientation.Landscape;

            Current.Resources["TabBarHeight"] = 100;

            //App.vScale = height > 700 ? 1.4 : height / 568;
            //App.dScale = height > 700 ? 2.5 : 1;

            Debug.WriteLine("Height: " + height);
            Debug.WriteLine("Width : " + width);
            //Debug.WriteLine("dScale: " + App.dScale);
            //Debug.WriteLine("vScale: " + App.vScale);

            // Word Area

            //Current.Resources["WordAreaPadding"] = 30 * vScale;

            // Page

            Current.Resources["PageMarginNew"] = 17;
            Current.Resources["PageMargin"] = devIsIOS ? new Thickness(0) : new Thickness(0, 50, 0, 0);
            Current.Resources["BackArrowFontSize"] = 25;
            //Current.Resources["PageTitleFontSize"] = devIsIOS ? 17 : (14 * vScale);

            // Line

            Current.Resources["LineHeight"] = 1 / mainDisplayInfo.Density;

            // Frame

            Current.Resources["FrameMargin"] = new Thickness(15, 2, 15, 15);
            Current.Resources["FrameCornerRadius"] = 10;
            Current.Resources["FrameBorderPadding"] = new Thickness(0);
            Current.Resources["FrameElevation"] = devIsIOS ? 1.0f : 5.0f;

            // Grid

            Current.Resources["GridGridPadding"] = new Thickness(15, 0);
            //Current.Resources["GridHeight"] = 35 * vScale;

            // Headers and Footers

            Current.Resources["HeaderMargin"] = new Thickness(15, 15, 15, 15);
            Current.Resources["SubHeaderMargin"] = new Thickness(15, 5, 15, 5);
            Current.Resources["FooterMargin"] = new Thickness(15, 15, 15, 15);
            Current.Resources["InfoMargin"] = new Thickness(15, 15, 15, 15);
            //Current.Resources["SpacerHeight"] = 5 * vScale;
            //Current.Resources["vScale"] = vScale;

            // Info

            //Current.Resources["CardInfoMargin"] = App.devIsTablet ? new Thickness(15, 15) : new Thickness(15, 12, 15, 9);

            // Fonts

            //Current.Resources["ArrowFontSize"]          = devIsIOS ? 14    : (12 * vScale);
            //Current.Resources["DetailLabelFontSize"]    = devIsIOS ? (30 * dScale) : (40 * dScale);
            Current.Resources["FontAwesomeRegularXSFontSize"] = 11; // devIsIOS ? 11 : (10 * vScale);
            Current.Resources["HeaderTextFontSize"]           = 17; // devIsIOS ? 17    : (14 * vScale);
            Current.Resources["SubHeaderTextFontSize"]        = 15;  // devIsIOS ? 15    : (12 * vScale);
            Current.Resources["InfoTextFontSize"]             = 13;  // devIsIOS ? 13    : (10 * vScale);
            Current.Resources["LabelTextFontSize"]            = 14.5;  // devIsIOS ? 14.5 : 14.5; // (12 * vScale);
            Current.Resources["ListTextFontSize"]             = 13.5;  // devIsIOS ? 13.5  : (12 * vScale);
            Current.Resources["TickFontSize"]                 = 18;  // devIsIOS ? 18    : (14 * vScale);
            Current.Resources["WordTypeTextFontSize"]         = 13.25;  // devIsIOS ? 13.25 : (10.5 * vScale);
                                                                  
            Current.Resources["GridButtonFontSize"]           = devIsIOS ? 14.5  : 12.5;
            Current.Resources["PageButtonFontSize"]           = 12;
            Current.Resources["PLWButtonFontSize"]            = 13;
            Current.Resources["PLRButtonFontSize"]            = 13;

            // Buttons

            Current.Resources["GridButtonPadding"] = new Thickness(5, 0, 5, 0);
            Current.Resources["GridButtonHeightRequest"] = 26;
            Current.Resources["GridButtonCornerRadius"] = 5;
            Current.Resources["GLIButtonCornerRadius"] = 5;
            Current.Resources["GLIButtonWidthRequest"] = 24;
            Current.Resources["GLIButtonHeightRequest"] = 24;
            Current.Resources["GLIButtonPadding"] = new Thickness(0);

            Current.Resources["PageButtonPadding"] = new Thickness(5, 0, 5, 0);
            Current.Resources["PLRButtonWidthRequest"] = 50;
            Current.Resources["PLRButtonHeightRequest"] = 50;
            Current.Resources["PLRButtonCornerRadius"] = 25;
            Current.Resources["PLWButtonHeightRequest"] = 50;
            Current.Resources["PLWButtonCornerRadius"] = 10;

            // Icon

            //Current.Resources["IconHeight"] = devIsIOS ? (40 * vScale) : (25 * vScale);
            //Current.Resources["IconWidth"] = devIsIOS ? (33.5 * vScale) : (45 * vScale);
            //Current.Resources["IconFontSize"] = devIsIOS ? (30 * vScale) : (37 * vScale);
        }

    }
}