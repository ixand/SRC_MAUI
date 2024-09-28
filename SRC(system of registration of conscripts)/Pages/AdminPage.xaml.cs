namespace SRC_system_of_registration_of_conscripts_.Pages;

public partial class AdminPage : ContentPage
{
	public AdminPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayActionSheet("Оберіть","Відміна","Готово", "Підлягає призову", "Придатний до служби", "Обмежено придатний", "Тимчасово непридатний", "Звільнений від призову", "Отримав відстрочку");
    }
}