using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using D.Classes;
using SQLite;

namespace D
{
	/// <summary>
	/// Interaction logic for NewContactWindow.xaml
	/// </summary>
	public partial class NewContactWindow : Window
	{
		public NewContactWindow()
		{
			InitializeComponent();
		}
        
		private void saveButton_Click(object sender, RoutedEventArgs e)
		{
			// To Do : Save contact
			Contact contact = new Contact()
			{
				Name = nameTextBox.Text, 
				Email = emailTextBox.Text,
				Phone = phoneNumberTextBox.Text
			};

			// establish a connection to the database, implement the IDisposable interface
			// this connection object will be automatically disposed of when closed
			// instead of thinking all the time of closing a connection, use this "using" strategy to create & dispose objects.
			using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
			{
				// create a table
				// if the table already exists, nothing happens
				connection.CreateTable<Contact>();
				// insert a record
				connection.Insert(contact);
			}

			Close(); // can also use this.Close().  But we don't need this since just Close indicates it is coming directly from Window (i.e. NewContactWindow : Window)
			         // Close is a method inherited from Window class
		}
	}
}
