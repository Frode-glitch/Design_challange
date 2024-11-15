namespace Designchallenge;

public partial class ProfileView : ContentPage
{
   // private readonly AuthService _authService;

    public ProfileView()
	{
		InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(LoginView)}");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("AccountView");
    }
}