using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for INotifyPropertyChanged
using System.ComponentModel;

namespace F.Model
{
	public class Country
	{
		public string ID { get; set; }
		public string LocalizedName { get; set; }
	}

	public class AdministrativeArea
	{
		public string ID { get; set; }
		public string LocalizedName { get; set; }
	}

	public class AutoComplete : INotifyPropertyChanged
	{
		public int Version { get; set; }
		public string Key { get; set; }
		public string Type { get; set; }
		public int Rank { get; set; }
		public string LocalizedName { get; set; }
		public Country Country { get; set; }
		public AdministrativeArea AdministrativeArea { get; set; }

		// this causes an event to be raised everytime a property changes (due to set)
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			// checks to see if the property that has been changed has a handler associated with it
			// if so, only then do we raise an event
			// we don't want to raise an event unless there is a handler for it or we will cause a problem
			if (PropertyChanged != null)
			{
				//PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
