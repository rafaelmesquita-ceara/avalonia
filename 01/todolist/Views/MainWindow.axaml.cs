using Avalonia.Controls;
using todolist.ViewModels;

namespace todolist.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}