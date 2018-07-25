using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For INotifyPropertyChanged
using System.ComponentModel;

namespace G.Model
{
	public class Note : INotifyPropertyChanged
	{
		// Id ----------
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		// NotepadId - The Id of the notebook to which this node is part of
		private int notebookId;
		public int NotebookId
		{
			get { return notebookId; }
			set { notebookId = value; }
		}

		// Title ----------
		private string title;
		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		// DateTime ----------
		private DateTime createdTime;
		public DateTime CreatedTime
		{
			get { return createdTime; }
			set { createdTime = value; }
		}

		// UpdatedTime ----------
		private DateTime updatedTime;
		public DateTime UpdatedTime
		{
			get { return updatedTime; }
			set { updatedTime = value; }
		}

		// FileLocation - Path to a location on the disk where a txt file is saved
		private int fileLocation;
		public int FileLocation
		{
			get { return fileLocation; }
			set { fileLocation = value; }
		}

		// ----------------------------------------------------------------------------------
		// This causes an event to be raised everytime a property changes (due to set)
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			// checks to see if the property that has been changed has a handler associated with it
			// if so, only then do we raise an event
			// we don't want to raise an event unless there is a handler for it or we will cause a problem
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
