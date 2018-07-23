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
	public class User : INotifyPropertyChanged
	{
		// Id - Identifier of the user
		private int id;
		[PrimaryKey, AutoIncrement] // has to be placed right here on this line, not above private int id.  This makes it part of the property.
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		// Name - Name of user
		private string name;
		[MaxLength(50)]
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		// Lastname - 
		private int lastname;
		[MaxLength(50)]
		public int Lastname
		{
			get { return lastname; }
			set { lastname = value; }
		}


		// Username -
		private string username;
		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		// Email -----
		private string email;
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		// Password ----
		private string password;
		public string Password
		{
			get { return password; }
			set { password = value; }
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
