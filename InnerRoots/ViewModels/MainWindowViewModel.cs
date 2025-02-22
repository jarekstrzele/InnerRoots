using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using InnerRoots.Models;

namespace InnerRoots.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
     public ObservableCollection<Person> People { get; set; } = new();
     public Person SelectedPerson { get; set; }

     public ICommand AddPersonCommand { get; }

     public MainWindowViewModel()
     {
          AddPersonCommand = new RelayCommand(AddPerson);
     }

     private void AddPerson()
     {
          People.Add(new Person { FirstName = "John", LastName = "Doe" });
     }
}