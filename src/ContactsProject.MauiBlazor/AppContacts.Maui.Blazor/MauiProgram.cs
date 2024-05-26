using AppContacts.Maui.Blazor.Services;
using AppContacts.Shared.Blazor;
using AppContacts.Shared.Blazor.Services;

namespace AppContacts.Maui.Blazor;

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
            });

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        builder.Services.AddBlazorServices("https://localhost:44354");
        //builder.Services.AddBlazorServices("https://localhost:5026");
        builder.Services.AddSingleton<IStorageService, MauiStorageService>();
        
        return builder.Build();
    }
}
