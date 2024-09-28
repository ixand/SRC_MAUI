using SRC_system_of_registration_of_conscripts_.Pages;

namespace SRC_system_of_registration_of_conscripts_.Views;

public partial class UserAccount : TabbedPage
{
    public static string Name;
	public UserAccount(string name)
	{
        
        InitializeComponent();

        Name = name;

        if (name != "admin") 
        {
            Children.Remove(admin_p);
        }
        else
        {
            Children.Remove(conscript_p);
        }

        
    }

    
}