using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Model
{
	class Note
	{
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		// ----------

		private int notebookId;

		public int NotebookId
		{
			get { return notebookId; }
			set { notebookId = value; }
		}

		// ----------

		private int title;

		public int Title
		{
			get { return title; }
			set { title = value; }
		}

		// ----------

		private DateTime createdTime;

		public DateTime CreatedTime
		{
			get { return createdTime; }
			set { createdTime = value; }
		}

		// ----------

		private DateTime updatedTime;

		public DateTime UpdatedTime
		{
			get { return updatedTime; }
			set { updatedTime = value; }
		}

		// ----------

		private int fileLocation;

		public int FileLocation
		{
			get { return fileLocation; }
			set { fileLocation = value; }
		}
	}
}
