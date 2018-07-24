using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For IPropertyChanged
using System.ComponentModel;

// After installing sql
using SQLite;

namespace G.Model
{
	public class Notebook : INotifyPropertyChanged
	{
		// Id ----
		private int id;
		[PrimaryKey, AutoIncrement]
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		// UserId --------
		private int userId;
		[Indexed] // Indexed - works like a foreign key
		public int UserId
		{
			get { return userId; }
			set { userId = value; }
		}

		// Name --------
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
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
