using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace todolist.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<ToDoItemViewModel> ToDoItems { get; } = new ObservableCollection<ToDoItemViewModel>();

    [ObservableProperty] 
    [NotifyCanExecuteChangedFor(nameof(AddItemCommand))]
    private string? _newItemContent;
    
    private bool CanAddItem() => !string.IsNullOrWhiteSpace(NewItemContent);
    
    [RelayCommand (CanExecute = nameof(CanAddItem))]
    private void AddItem()
    {
        // Add a new item to the list
        ToDoItems.Add(new ToDoItemViewModel() {Content = NewItemContent});

        // reset the NewItemContent
        NewItemContent = null;
    }
    
    [RelayCommand]
    private void RemoveItem(ToDoItemViewModel item)
    {
        // Remove the given item from the list
        ToDoItems.Remove(item);
    }
}