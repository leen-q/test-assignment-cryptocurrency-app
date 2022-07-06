using System;
using System.Windows.Input;
using TestAssignment.ViewModels;

namespace TestAssignment.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter.ToString() == "Main")
            {
                viewModel.SelectedViewModel = new StarterPageViewModel();
            }
            else if(parameter.ToString() == "Currency")
            {
                viewModel.SelectedViewModel = new DetailPageViewModel();
            }
        }
    }
}
