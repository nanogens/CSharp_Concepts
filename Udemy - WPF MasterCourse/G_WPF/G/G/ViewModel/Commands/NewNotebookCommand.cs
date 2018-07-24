using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For ICommand
using System.Windows.Input;

namespace G.ViewModel.Commands
{
	public class NewNotebookCommand : ICommand
	{
		public NotesVM VM { get; set; }

		public event EventHandler CanExecuteChanged;

		public NewNotebookCommand(NotesVM vm)
		{
			VM = vm;
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			//TODO: Create new Notebook
		}
	}
}
