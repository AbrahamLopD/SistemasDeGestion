using _07_Pages_MAUI.Views;

namespace _07_Pages_MAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public async void OnNav(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new TabbedPageView());
    }

}