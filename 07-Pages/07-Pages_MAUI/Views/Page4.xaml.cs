using _07_Pages_Entidades;

namespace _07_Pages_MAUI.Views;

public partial class Page4 : ContentPage
{
    private Persona persona;

    public Page4()
	{
		InitializeComponent();
	}

    public Page4(Persona persona)
    {
        InitializeComponent();
        this.persona = persona;
        lblPersona.Text = this.persona.Nombre + " " + this.persona.Apellidos;
    }
}