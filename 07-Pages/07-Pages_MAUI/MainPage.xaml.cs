using _07_Pages_MAUI.Views;
using _07_Pages_Entidades;

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

    private async void OnNavPage4(object sender, EventArgs e)
    {
        Persona persona = new Persona();

        if (String.IsNullOrEmpty(inputNombre.Text))
        {
            inputNombre.Text = "";
        }

        if (String.IsNullOrEmpty(inputApellidos.Text))
        {
            inputApellidos.Text = "";
        }

        persona = new Persona(inputNombre.Text, inputApellidos.Text);
        await Navigation.PushAsync(new Page4(persona));
    }

    private async void OnNavPage5(object sender, EventArgs e)
    {
        Persona persona = new Persona();

        if (String.IsNullOrEmpty(inputNombre.Text))
        {
            inputNombre.Text = "";
        }

        if (String.IsNullOrEmpty(inputApellidos.Text))
        {
            inputApellidos.Text = "";
        }

        persona = new Persona(inputNombre.Text, inputApellidos.Text);
        await Navigation.PushAsync(new Page5 { BindingContext = persona });
    }

}