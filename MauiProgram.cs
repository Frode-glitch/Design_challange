using Design_challenge.Services;
using Design_challenge.Views;
using Microsoft.Extensions.Logging;

namespace Design_challenge
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Futura-Bold-font.ttf", "bold");
                    fonts.AddFont("Futura-medium-bt.ttf", "medium");
                    fonts.AddFont("FontAwesomeSolid.otf", "AwesomeSolid");
                    fonts.AddFont("Baloo2-Medium.ttf", "Baloo2");
                    fonts.AddFont("Baloo-Regular.ttf", "Baloo");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<AuthService>();
            builder.Services.AddTransient<LoadingView>();
            builder.Services.AddTransient<LoginView>();
            builder.Services.AddTransient<ProfileView>();

            return builder.Build();
        }
    }
}
