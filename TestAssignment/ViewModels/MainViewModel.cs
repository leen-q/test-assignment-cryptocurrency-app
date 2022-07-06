using System.Windows.Input;
using TestAssignment.Commands;

namespace TestAssignment.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand UpdateViewCommand { get; set; }

        private BaseViewModel _selectedViewModel = new StarterPageViewModel();
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set 
            { 
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
