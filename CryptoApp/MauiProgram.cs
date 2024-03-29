﻿using CryptoApp.Services;
using CryptoApp.Views;
using Microsoft.Extensions.Logging;

namespace CryptoApp
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<Bitcoin>();
            builder.Services.AddSingleton<Ethereum>();
            builder.Services.AddSingleton<ICryptoPriceService, TestPriceService>();

            return builder.Build();
        }
    }
}
