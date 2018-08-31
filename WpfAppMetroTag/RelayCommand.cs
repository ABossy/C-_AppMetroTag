using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppMetroTag
{
    class RelayCommand : ICommand
    {
        private Action _execute;
        private bool _canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action execute)
        {
            this._execute = execute;
            this._canExecute = true;
        }

        public void Execute (object parameter)
        {
            this._execute();
        }

        public bool CanExecute (object parameter)
        {
            return this. _canExecute;
        }
    }
}
