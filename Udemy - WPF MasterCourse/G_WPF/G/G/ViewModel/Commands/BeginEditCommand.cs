using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace G.ViewModel.Commands
{
	public class BeginEditCommand : ICommand  // this command will implement the ICommand interface
	{
		public NotesVM Vm { get; set; } // a property of type NotesVM 
		public event EventHandler CanExecuteChanged;

		public BeginEditCommand(NotesVM vm) // ctor <tab>   Constructor
		{
			Vm = vm; // set the property to notes vm
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			Vm.StartEditing();
		}
	}
}
