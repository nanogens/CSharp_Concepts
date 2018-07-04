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
using System.Windows.Navigation;
using System.Windows.Shapes;

using D.Classes;

namespace D.Controls
{
	/// <summary>
	/// Interaction logic for ContactControl.xaml
	/// </summary>
	public partial class ContactControl : UserControl
	{
		// Commented what's below out because we need a Dependency property, not this kind of property!
		//private Contact contact;
		//public Contact Contact
		//{
		//	get { return contact; }
		//	set
		//	{
		//		contact = value;
		//		nameTextBlock.Text = contact.Name;
		//		phoneTextBlock.Text = contact.Phone;
		//		emailTextBlock.Text = contact.Email;
		//	}
		//}

		// propdp - A Dependency Property (Need it to bind. To provide a way to compute the value of a property based on different inputs).
		// Not just going to be a basic setter/getter.  Its going to use binding that different input the one setting the value for this property. (what??)
		// Typed in propdp and hit tab.  Made a few modification like in typeof() from ownerwhatever to ContactControl
		public Contact Contact
		{
			get { return (Contact)GetValue(ContactProperty); }
			set { SetValue(ContactProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Contact.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ContactProperty =      
			                                        // default value to a contact cannot be 0. So either we put null in its place or we put in a default record in the contact
				//DependencyProperty.Register("Contact", typeof(Contact), typeof(ContactControl), new PropertyMetadata(new Contact() { Name = "Name Lastname", Email = "test@tst.com", Phone = "(647) 888 9999" }, SetText)); // put your cursor in SetText and hit Ctrl . (Control dot) and then Generate SetText.
		    DependencyProperty.Register("Contact", typeof(Contact), typeof(ContactControl), new PropertyMetadata(null, SetText)); 


		// This is the method that gets called as defined by the dependency property when there is a change detected by the control
		private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			//throw new NotImplementedException(); // delete this line
			ContactControl control = d as ContactControl;
			if(control != null)
			{
				control.nameTextBlock.Text = (e.NewValue as Contact).Name; // new value that the control says has changed gets assigned to the variable
				control.emailTextBlock.Text = (e.NewValue as Contact).Email;
				control.phoneTextBlock.Text = (e.NewValue as Contact).Phone;
			}
		}

		public ContactControl()
		{
			InitializeComponent();
		}
	}
}
