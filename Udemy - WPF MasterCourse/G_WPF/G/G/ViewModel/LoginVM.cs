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

		// we added this event handler.  HasLoggedIn will be fired when an event is raised.
		public event EventHandler HasLoggedIn;

		public LoginVM()
		{
			RegisterCommand = new RegisterCommand(this);
			LoginCommand = new LoginCommand(this);
			User = new Model.User();  // not present in 
		}

		public void Login()  // this method will be using the User (which is bound to what we have in the login window) to evaluate if there exist a user with the name & password in the sqllite database
		{
			using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))  // to create the connection to the db.  Through DaabaseHelper we have access to the db file.
			{
				conn.CreateTable<User>(); // create the user table in case it is not there yet
				var user = conn.Table<User>().Where(u => u.Username == User.Username).FirstOrDefault();
				// check if the user has a password and compare it to the user's password bound to this class.
				if(user.Password == User.Password)
				{
					// TODO : establish Login
					App.UserId = user.Id.ToString(); // Assign user id which we got to the app's user id.  cast it as a string since its an integer
					// event
					HasLoggedIn(this, new EventArgs()); // sender, new events arguments.  this is how we fire this event
				}
			}
		}

		public void Register()
		{
			using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(DatabaseHelper.dbFile))  // to create the connection to the db.  Through DaabaseHelper we have access to the db file.
			{
				conn.CreateTable<User>(); // create the user table in case it is not there yet
				// will insert the user - the user that is now bound to the property
				var result = DatabaseHelper.Insert(User);
				if(result)
				{
					// TODO : establish register
					App.UserId = User.Id.ToString();
				}
			}
		}
	}
}
