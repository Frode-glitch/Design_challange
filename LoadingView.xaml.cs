using Designchallenge.Services;

namespace Designchallenge;

public partial class LoadingView : ContentPage
{
    private readonly AuthService _authService;

    public LoadingView(AuthService authService)
	{
		InitializeComponent();
        _authService = authService;
    }

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (await _authService.IsAuthenticatedAsync())
        {
            //gebruiker is ingelogd
            //redirecten naar mainpage
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
        else
        {
            //gebruiker is niet ingelogd
            //redirecten naar loginview
            await Shell.Current.GoToAsync($"//{nameof(LoginView)}");
        }
    }
}