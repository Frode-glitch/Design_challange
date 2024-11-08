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
}