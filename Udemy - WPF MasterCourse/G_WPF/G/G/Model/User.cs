using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Model
{
	public class User
	{
		// Id -----
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		// Name -----
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		// Username -----
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
	}
}
