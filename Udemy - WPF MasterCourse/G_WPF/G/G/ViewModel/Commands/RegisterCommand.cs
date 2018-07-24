using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for ICommand, also right click on ICommand and Implement the interface
using System.Windows.Input;

namespace G.ViewModel.Commands
{
	// Register command is the command to be executed when the register button is pressed
	public class RegisterCommand : ICommand
	{

		public LoginVM VM { get; set; }
		public event EventHandler CanExecuteChanged;

		public RegisterCommand(LoginVM vm)
		{
			VM = vm;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			//TODO: Login functionality
		}
	}
}
