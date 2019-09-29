using Xamarin.Forms;

namespace Japanese
{
    public partial class App : Application
    {

        public static void SetResourceFonts()
        {
          
            Current.Resources["FALight"] = Device.RuntimePlatform == Device.iOS ?
                                                "FontAwesome5Pro-Light" :
                                                "Font Awesome 5 Pro-Light-300.otf#FontAwesome5Pro-Light";
            Current.Resources["FARegular"] = Device.RuntimePlatform == Device.iOS ?
                                                "FontAwesome5Pro-Regular" :
                                                "Font Awesome 5 Pro-Regular-400.otf#FontAwesome5Pro-Regular";
            Current.Resources["DefaultFont"] = Device.RuntimePlatform == Device.iOS ?
                                                "Roboto-Regular" :
                                                "Roboto-Regular.ttf#Roboto-Regular";
            Current.Resources["Roboto-Light"] = Device.RuntimePlatform == Device.iOS ?
                                                "Roboto-Light" :
                                                "Roboto-Light.ttf#Roboto-Light";

        }

    }
}