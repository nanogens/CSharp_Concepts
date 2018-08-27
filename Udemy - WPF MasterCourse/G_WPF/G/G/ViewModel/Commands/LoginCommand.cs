using G.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For ICommand
using System.Windows.Input;

namespace G.ViewModel.Commands
{
	public class LoginCommand : ICommand
	{
		public LoginVM VM { get; set; }

		public event EventHandler CanExecuteChanged;

		public LoginCommand(LoginVM vm)
		{
			VM = vm;
		}

		// CanExecute is like IsEnabled
		public bool CanExecute(object parameter)
		{
			// bind to a parameter
			var user = parameter as User;
			
			// if neither username or password entered, return false
			if (string.IsNullOrEmpty(user.Username))
			{
				return false;
			}
			if (string.IsNullOrEmpty(user.Password))
			{
				return false;
			}
			return true;
		}

		public void Execute(object parameter)
		{
			//TODO: Login functionality
			// From the Execute command we will call the Login Method in LoginVM
			VM.Login();
		}
	}
}
