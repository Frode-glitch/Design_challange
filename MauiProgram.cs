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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<AuthService>();
            builder.Services.AddTransient<LoadingView>();

            return builder.Build();
        }
    }
}
