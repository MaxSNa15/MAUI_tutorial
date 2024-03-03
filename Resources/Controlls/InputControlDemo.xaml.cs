namespace MauiApp2_Controles;

public partial class InputControlDemo : ContentPage
{
	public InputControlDemo()
	{
		InitializeComponent();
	}

    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		lblSliderValue.Text = slider1.Value.ToString();
    }

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (stepper1 != null)
        {
            lblSliderValue.Text = stepper1.Value.ToString();
        }
    }
}