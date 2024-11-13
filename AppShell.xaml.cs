using Design_challenge.Views;

namespace Design_challenge
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(ListingView), typeof(ListingView));
            Routing.RegisterRoute(nameof(LoadingView), typeof(LoadingView));
            Routing.RegisterRoute(nameof(LoginView), typeof(LoginView));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(ProfileView), typeof(ProfileView));
            Routing.RegisterRoute(nameof(AccountView), typeof(AccountView));
            Routing.RegisterRoute(nameof(Deal1View), typeof(Deal1View));
        }
    }
}
