using Designchallenge.Services;
using Microsoft.Extensions.Logging;

namespace Designchallenge
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

            string connectionString = "Server=127.0.0.1;Database=pointpark2;User Id=admin;Password=admin;";

            builder.Services.AddSingleton<ListingView>();
            builder.Services.AddSingleton<AuthService>();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddTransient<LoadingView>();
            builder.Services.AddTransient<LoginView>();
            builder.Services.AddTransient<ProfileView>();
            builder.Services.AddTransient<Deal1View>();
            builder.Services.AddTransient<QRCodeDeal1>();

            return builder.Build();
        }
    }
}

