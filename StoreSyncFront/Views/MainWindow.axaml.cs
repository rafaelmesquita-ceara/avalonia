using System;
using System.Net.Http;
using Avalonia.Controls;
using StoreSyncFront.Services;
using StoreSyncFront.ViewModels;

namespace StoreSyncFront.Views;

public partial class MainWindow : Window
{
    private INavigationService _navigationService;
    public MainWindow(MainWindowViewModel viewModel, INavigationService navigationService)
    {
        this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        this.CanResize = false;
        InitializeComponent();
        DataContext = viewModel;
        
        this._navigationService = navigationService;
        navigationService.Initialize(ContentHost);
        navigationService.NavigateTo<LoginViewModel>();
    }
}