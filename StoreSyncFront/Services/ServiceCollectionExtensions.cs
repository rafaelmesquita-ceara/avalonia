﻿using System;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreSyncFront.ViewModels;
using StoreSyncFront.Views;

namespace StoreSyncFront.Services;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this IServiceCollection collection)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("./appsettings.json")
            .Build();
        
        var apiBaseUrl = config["ApiSettings:BaseUrl"];
        
        collection.AddSingleton(sp => 
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(apiBaseUrl)
            };
            return client;
        });
        
        collection.AddSingleton<IApiService, ApiService>();
        collection.AddSingleton<IAuthService, AuthService>();
        
        collection.AddTransient<LoginView>();
        collection.AddTransient<LoginViewModel>();
        
        collection.AddSingleton<MainWindow>();
        collection.AddSingleton<MainWindowViewModel>();
        collection.AddSingleton<MainViewModel>();
        
        collection.AddSingleton<INavigationService, NavigationService>();
    }
}