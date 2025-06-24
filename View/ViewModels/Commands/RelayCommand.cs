using System.Windows.Input;

namespace View.ViewModels.Commands 
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object?> _execute;
        public event EventHandler? CanExecuteChanged;

        public RelayCommand(Action<object?> execute) 
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        }

        public bool CanExecute(object? parameter) => true;        

        public void Execute(object? parameter) => _execute(parameter);
        
    }
}