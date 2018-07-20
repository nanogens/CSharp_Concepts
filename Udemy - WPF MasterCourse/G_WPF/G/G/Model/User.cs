using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Model
{
	public class User
	{
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		// -----

		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		// -----

		private string username;
		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		// -----

		private string email;
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		// ----

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}
	}
}
