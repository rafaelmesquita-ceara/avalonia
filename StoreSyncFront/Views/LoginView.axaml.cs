using Avalonia;
using Avalonia.Controls;
using System.Reactive;
using StoreSyncFront.Services;
using StoreSyncFront.ViewModels;

namespace StoreSyncFront.Views;

public partial class LoginView : UserControl
{
    private readonly AuthService _authService;
    public LoginView()
    {
        InitializeComponent();

        this.AttachedToVisualTree += (_, _) =>
        {
            if (this.VisualRoot is Window window)
            {
                window.GetObservable(TopLevel.ClientSizeProperty)
                    .Subscribe(Observer.Create<Size>(size => AdjustLayout(size.Width)));
            }
        };
    }

    private void AdjustLayout(double width)
    {
        if (width < 600)
        {
            Grid.SetColumn(StackPanelLogin, 0);
            Grid.SetColumn(LoginImage, 0);
            LoginImage.IsVisible = false;
            LoginGrid.ColumnDefinitions = new ColumnDefinitions("1*");
        }
        else
        {
            LoginGrid.ColumnDefinitions = new ColumnDefinitions("1*,1*");
            Grid.SetColumn(StackPanelLogin, 0);
            Grid.SetColumn(LoginImage, 1);
            LoginImage.IsVisible = true;
        }
    }
}