using SRC_system_of_registration_of_conscripts_.Views;

namespace SRC_system_of_registration_of_conscripts_.Pages;

public partial class ConscriptPage : ContentPage
{
	public ConscriptPage()
	{

        InitializeComponent();

        string name = UserAccount.Name;

        if (name == "conscript2")
        {
            avatar.Source = "soldier2.jpg";
        }
        else if(name == "conscript1")
        {
            avatar.Source = "soldier1.jpg";
        }
        else
        {
            avatar.Source = "noimageavaible.jpg";
        }
        
	}

    
    

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("не готово","вибачте","ok");
       
    }
}