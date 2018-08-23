using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For returning User datatype.  User class found in G.Model 
using G.Model;
// For RegisterCommand
using G.ViewModel.Commands;

namespace G.ViewModel
{
	public class LoginVM
	{
		private User user;

		public User User
		{
			get { return user; }
			set { user = value; }
		}

		public RegisterCommand RegisterCommand { get; set; }

		public LoginCommand LoginCommand { get; set; }

		public LoginVM()
		{
			RegisterCommand = new RegisterCommand(this);
			LoginCommand = new LoginCommand(this);
		}

		public void Login()  // this method will be using the User (which is bound to what we have in the login window) to evaluate if there exist a user with the name & password in the sqllite database
		{
			using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))  // to create the connection to the db.  Through DaabaseHelper we have access to the db file.
			{
				conn.CreateTable<User>(); // create the user table in case it is not there yet
				var user = conn.Table<User>().Where(u => u.Username == User.Username).FirstOrDefault();
				
				if(user.Password == User.Password)
				{
					//TODO: establish functionality
				}
			}
		}

		public void Register()
		{
			using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))  // to create the connection to the db.  Through DaabaseHelper we have access to the db file.
			{
				conn.CreateTable<User>(); // create the user table in case it is not there yet

				conn.Insert(User);
				var result = DatabaseHelper.Insert(User);
				if(result)
				{
					// TODO : establish register
				}
			}
		}
	}
}
