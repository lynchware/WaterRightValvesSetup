using Microsoft.Extensions.Logging;
using WaterRightValves.Pages;
using WaterRightValves.ViewModel;

namespace WaterRightValves
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
                });
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<WiFiSelection>();
            builder.Services.AddTransient<Instructions>();
            builder.Services.AddTransient<WiFiPassword>();
            builder.Services.AddTransient<MACAddress>();
            builder.Services.AddTransient<Confirmation>();

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<WiFiSelectViewModel>();
            builder.Services.AddTransient<InstructionsViewModel>();
            builder.Services.AddTransient<WiFiPassViewModel>();
            builder.Services.AddTransient<MACViewModel>();
            builder.Services.AddTransient<ConfirmationViewModel>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
