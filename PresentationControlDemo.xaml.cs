namespace MauiApp2_Controles;

public partial class PresentationControlDemo : ContentPage
{
	public PresentationControlDemo()
	{
		InitializeComponent();
	}

    private void btnTest_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Titulo", "este es el mensaje", "OK");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("Titulo", $"Changed: {e.Value}", "OK");

    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Busqueda", $"Buscando: {searchControl.Text}", "OK");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {

    }
}