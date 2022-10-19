using _07_Pages_MAUI.Views.MenuFlyout;

namespace _07_Pages_MAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new FlyoutPageNavigation();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}