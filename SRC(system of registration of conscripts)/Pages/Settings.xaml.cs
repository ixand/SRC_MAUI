namespace SRC_system_of_registration_of_conscripts_.Pages;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}
    private async void Exit(object sender, EventArgs e)
    {
        Shell.Current.Navigation.PopModalAsync(true);
    }
}