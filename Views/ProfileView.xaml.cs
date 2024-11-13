using Design_challenge.Services;

namespace Design_challenge.Views;

public partial class ProfileView : ContentPage
{
    private readonly AuthService _authService;

    public ProfileView(AuthService authService)
	{
		InitializeComponent();
        _authService = authService;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _authService.Logout();
        Shell.Current.GoToAsync($"//{nameof(LoginView)}");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("AccountView");
    }
}