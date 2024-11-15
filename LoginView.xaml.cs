

using Designchallenge.Services;

namespace Designchallenge;

public partial class LoginView : ContentPage
{
    private readonly AuthService _authService;

    public LoginView(AuthService authService)
    {
        InitializeComponent();
        _authService = authService;
    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
        _authService.Login();
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}