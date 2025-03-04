﻿using Microsoft.Extensions.Logging;
using WidgetBoard.Pages;
using WidgetBoard.ViewModels;

namespace WidgetBoard;

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

        AddPage<BoardDetailsPage, BoardDetailsPageViewModel>(builder.Services, "boarddetails");
        AddPage<FixedBoardPage, FixedBoardPageViewModel>(builder.Services, "fixedboard");
        builder.Services.AddTransient<AppShell>();
        builder.Services.AddTransient<AppShellViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

    private static IServiceCollection AddPage<TPage, TViewModel>(
        IServiceCollection services,
        string route)
        where TPage : Page
        where TViewModel : BaseViewModel
    {
        services
            .AddTransient(typeof(TPage))
            .AddTransient(typeof(TViewModel));
        Routing.RegisterRoute(route, typeof(TPage));
        return services;
    }
}