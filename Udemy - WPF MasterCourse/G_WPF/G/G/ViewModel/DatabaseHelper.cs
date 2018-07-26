using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for Path
using System.IO;

// for SQLiteConnection
using SQLite;

namespace G.ViewModel
{
	// Will help us insert, delete and update elements directly from this class
	public class DatabaseHelper
	{
		// we make these variables static so we don't have to create an instance of the database helper class

		// to establish were the sql lite database is to be stored
		public static string dbFile = Path.Combine(Environment.CurrentDirectory, "notesDb.db3");

		// to establish a generic method, we use <T> to indicate we will be receiving a type
		public static bool Insert<T>(T item)
		{
			bool result = false;
			// open a connection to the database
			using (SQLiteConnection conn = new SQLiteConnection(dbFile)) 
			{
				conn.CreateTable<T>(); // establish first that the table exists.  we create a table of T type.
				int numberOfRows = conn.Insert(item); // returns the amount of rows that were added
				if(numberOfRows > 0)
				{
					result = true;
				}
			}
			return result;
		}

		public static bool Update<T>(T item)
		{
			bool result = false;
			// open a connection to the database
			using (SQLiteConnection conn = new SQLiteConnection(dbFile))
			{
				conn.CreateTable<T>(); // establish first that the table exists.  we create a table of T type.
				int numberOfRows = conn.Update(item); // returns the amount of rows that were updated
				if (numberOfRows > 0)
				{
					result = true;
				}
			}
			return result;
		}

		public static bool Delete<T>(T item)
		{
			bool result = false;
			// open a connection to the database
			using (SQLiteConnection conn = new SQLiteConnection(dbFile))
			{
				conn.CreateTable<T>(); // establish first that the table exists.  we create a table of T type.
				int numberOfRows = conn.Delete(item); // returns the amount of rows that were deleted
				if (numberOfRows > 0)
				{
					result = true;
				}
			}
			return result;
		}
	}
}
