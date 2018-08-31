using G.Model;
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
			var user = parameter as User;
			// if no username or password has been entered
			if (user != null)
			{
				if (string.IsNullOrEmpty(user.Username))
					return false;
				if (string.IsNullOrEmpty(user.Password))
					return false;
				if (string.IsNullOrEmpty(user.Email))
					return false;
				if (string.IsNullOrEmpty(user.Lastname))
					return false;
				if (string.IsNullOrEmpty(user.Name))
					return false;
			}
			return true;
		}

		public void Execute(object parameter)
		{
			//TODO: Login functionality
			VM.Register();
		}
	}
}
