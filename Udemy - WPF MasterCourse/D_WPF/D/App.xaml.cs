using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace D
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static string databaseName = "Contacts.db";  // only databaseName needs to be defined as public, the two items below can remain as (default) private variables
		static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		public static string databasePath = System.IO.Path.Combine(folderPath, databaseName); // combines the above two strings (databaseName and folderPath)
	}
}
