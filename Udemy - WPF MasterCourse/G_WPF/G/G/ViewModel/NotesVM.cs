using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For ObservableCollection<>
using System.Collections.ObjectModel;
using G.Model;

// For NewNotebookCommand
using G.ViewModel.Commands;

namespace G.ViewModel
{
	public class NotesVM
	{
		// This Notebook property is eventually going to be bound to a Listview displaying Notebooks
		public ObservableCollection<Notebook> Notebooks { get; set; }

		private Notebook selectedNotebook;
		// get the notes everytime a note is selected...
		public Notebook SelectedNotebook
		{
			get { return selectedNotebook; }
			set
			{
				selectedNotebook = value;
				//TODO : get notes
			}
		}

		// ... and store them inside this observable collection
		public ObservableCollection<Note> Notes { get; set; }

		public NewNotebookCommand NewNotebookCommand { get; set; }
		public NewNoteCommand NewNoteCommand { get; set; }

		public NotesVM()
		{
			// we are simply creating the properties that will eventually be bound to elements inside of the view
			// we are creating the properties & commands ready to be bound
			NewNoteCommand = new NewNoteCommand(this);
			NewNotebookCommand = new NewNotebookCommand(this);

			// Initialize both the Notebooks and Notes variables/properties - an observable collection 
			Notebooks = new ObservableCollection<Notebook>();
			Notes = new ObservableCollection<Note>();

      ReadNotebooks();
		}

		public void CreateNotebook()
		{
			Notebook newNotebook = new Notebook()
			{
				Name = "New Notebook"
			};
			DatabaseHelper.Insert(newNotebook);
		}

		public void CreateNote(int notebookId)
		{
			Note newNote = new Note()
			{
				NotebookId = notebookId,
				CreatedTime = DateTime.Now,
				UpdatedTime = DateTime.Now,
				Title = "New Note"
			};
			// we don't need the angled brackets <Note> to pass in because the 
			// parameter we are passing in already contains the Note definition
			DatabaseHelper.Insert(newNote);
		}

		public void ReadNotebooks()
		{
			using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))
			{
				var notebooks = conn.Table<Notebook>().ToList();

				Notebooks.Clear();
				foreach(var notebook in notebooks)
				{
					Notebooks.Add(notebook); // adding to the same instance of Notebook.  this is bound.
				}
			}
		}

		public void ReadNotes()
		{
			using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))
			{
                if (SelectedNotebook != null)
                {
                    // filter by NotebookId
                    // identify which note inside of the notebook table has that id
                    // that way we will be identifying each and every one of the notes
                    var notes = conn.Table<Note>().Where(n => n.NotebookId == SelectedNotebook.Id).ToList();

                    Notes.Clear();
                    foreach(var note in notes)
                    {
                        Notes.Add(note);
                    }
                }
			}   
		}
	}
}
