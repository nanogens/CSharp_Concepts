using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Model
{
	class Note
	{
		// Id ----------
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		// NotepadId ----------
		private int notebookId;
		public int NotebookId
		{
			get { return notebookId; }
			set { notebookId = value; }
		}

		// Title ----------
		private int title;
		public int Title
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

		// FileLocation ----------
		private int fileLocation;
		public int FileLocation
		{
			get { return fileLocation; }
			set { fileLocation = value; }
		}
	}
}
