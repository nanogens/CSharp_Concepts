using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.Model
{
	class Notebook
	{
		// Id ----
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		// UserId --------
		private int userId;
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
	}
}
