using System;
using System.Net.Http;
using System.Windows.Input;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using StoreSyncFront.Services;
using StoreSyncFront.Views;
using ReactiveUI;

namespace StoreSyncFront.ViewModels;


public class MainViewModel : ObservableObject
{
    private readonly INavigationService _navigationService;
    
    public MainViewModel(INavigationService navigationService)
    {
        this._navigationService = navigationService;
        OpenLoginCommand = ReactiveCommand.Create(OpenLoginView);
        _navigationService.NavigateTo<LoginViewModel>();
    }
    
    public ICommand OpenLoginCommand { get; }

    public void OpenLoginView()
    {
        _navigationService.NavigateTo<LoginViewModel>();
    }
}