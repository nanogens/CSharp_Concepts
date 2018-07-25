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
	public class NewNoteCommand : ICommand
	{
		public NotesVM VM { get; set; }

		public event EventHandler CanExecuteChanged;

		public NewNoteCommand(NotesVM vm)
		{
			VM = vm;
		}

		// evaluate to see if there is a notebook in which to create a note
		// evaluate in the canexecute if that notebook is different than NULL. 
		public bool CanExecute(object parameter)
		{
			// it will be upto me to bind this particular parameter to a Notebook (which is the case as seen in the NotesWindow.xaml)
			Notebook selectedNotebook = parameter as Notebook;
			if (selectedNotebook != null)
			{
				return true;
			}
			return false; 
		}

		public void Execute(object parameter)
		{
			// TODO: get Notes

			// get the selected Notebook
			Notebook selectedNotebook = parameter as Notebook;
			VM.CreateNote(selectedNotebook.Id);
		}
	}
}
