namespace _07_Pages_MAUI.Views;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

	public async void OnReturn(object sender, EventArgs args)
	{
		await Navigation.PopToRootAsync();
	}
}