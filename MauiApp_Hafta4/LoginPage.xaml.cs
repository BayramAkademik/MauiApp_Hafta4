namespace MauiApp_Hafta4;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void VisibleChange_Click(object sender, EventArgs e)
    {
		if (kayitStack.IsVisible)
		{
			loginStack.IsVisible = true;
			kayitStack.IsVisible = false;
		}else
		{
            loginStack.IsVisible = false;
            kayitStack.IsVisible = true;
        }
    }

    private void LoginClicked(object sender, EventArgs e)
    {
		bool login = true;
		if (login)
		{
			App.Current.MainPage = new AppShell();
		}
    }
}