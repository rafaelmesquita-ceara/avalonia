using System;
using System.Threading.Tasks;
using Avalonia.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Material.Styles.Controls;
using Material.Styles.Models;
using StoreSyncFront.Services;

namespace StoreSyncFront.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    private readonly IAuthService _authService;
    private readonly INavigationService _navigationService;

    [ObservableProperty]
    private string _login = string.Empty;

    [ObservableProperty]
    private string _senha = string.Empty;

    public LoginViewModel(IAuthService authService, INavigationService navigationService)
    {
        _authService = authService;
        _navigationService = navigationService;
    }

    [RelayCommand]
    private async Task Entrar()
    {
        if (string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Senha))
        {
            SnackBarService.Send("Os campos devem estar preenchidos!");
            return;
        }

        var sucesso = await _authService.Autenticar(Login, Senha);
        SnackBarService.Send(sucesso ? "Login realizado com sucesso." : "Credenciais inválidas.");
    }
}