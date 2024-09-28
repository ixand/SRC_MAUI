using SRC_system_of_registration_of_conscripts_.Database;
using SRC_system_of_registration_of_conscripts_.Pages;

namespace SRC_system_of_registration_of_conscripts_.Views;

public partial class AuthorizationView : ContentPage
{
    public AuthorizationView()
    {
        InitializeComponent();

    }

    private async void SignIn(object sender, EventArgs e)
    {
        DatabaseAcess databaseAcess = new();
        

        await ButtonEffect();

        
        try
        {
            await databaseAcess.Init();
            await DisplayAlert("Успіх", $"З'єднання з базою даних успішно встановлене!", "ок");
            Authorization();
        }
        
        catch (Exception ex)
        {
            await DisplayAlert("Помилка з'єднання з базою даних",$"{ex.Message}","ок");
        }
        
    }


    async void Authorization()
    {
        AccountsData data = new();

        if(login.Text == data.login && password.Text == data.password)
        {
            Shell.Current.Navigation.PushModalAsync(new UserAccount(data.login), true);
            

        }
        else if (login.Text == data.c1_login &&  password.Text == data.c1_password)
        {
            Shell.Current.Navigation.PushModalAsync(new UserAccount(data.c1_login), true);
        }
        else if (login.Text == data.c2_login && password.Text == data.c2_password)
        {
            Shell.Current.Navigation.PushModalAsync(new UserAccount(data.c2_login), true);
        }
        else
        {
            await DisplayAlert("Помилка","Схоже дані невірні!","ок");
            return;
        }
    }

    async Task ButtonEffect()
    {
        SignInButton.BackgroundColor = Color.Parse("#7FFFD4");
        await Task.Delay(50);
        SignInButton.BackgroundColor = Color.Parse("#008000");
    }



}


