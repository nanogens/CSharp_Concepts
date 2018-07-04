using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D.Classes
{
	public class Contact
	{
		[PrimaryKey, AutoIncrement] // use CTRL .  (CTRL dot) and then using SQLlite.  It designates PrimaryKey as a SQLlite attribute.
		public int Id { get; set; } // set in the database as the primary key (the unique identifier)
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return $"{Name} - {Email} - {Phone}";
        }
    }
}
