using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// to implement INotifyPropertyChanged
using System.ComponentModel;

#region Notes
// Note, based on the key that was created on the website AccuWeather (MyApps -> WPFWeatherApp) -> (API Key)
// we went to the (API Reference -> Current Conditions API) and for the Get method CurrentConditions(), 
// pasted in the (API Key), hit (Send this Request) and generated the JSON gobblygoop.
//
// Then we copy and pasted that JSON gobblygoop in jsonutils.com and after naming the class 
// AccuWeather and selecting C# as the language, generated the JSON in C# format.
// 
// Then we copied and pasted it below.
// We optimized it by unifying Metric and Imperial classes into one class called Measurement.
// And we got rid of some properties in the AccuWeather class which we probably won't need.
//
// If we plan to only use certain properties and not all of them, we can delete those properties from our class.
// Its ok to do so.  There's no problem if the JSON has some properties which the class does not.
// It just means when that specific proeprty is deserialized from the JSON, it won't be accessible in C#.
//
// Likewise, it does not matter if the C# has extra properties that are not in the JSON.
// It just means those properties will not be assigned a value when the JSON is deserialized. 
#endregion

namespace F.Model
{
	// Note : For Metric and Imperial classes, we do not need to raise an OnPropertyChanged() event.
	// So we exclude that line from Value (set), Unit (set) and UnitType (set).
	// When we included an OnPropertyChanged() event, the JSON deserializer crashed with some bullshit message.
	// So we exclude it.  Imperial and Metric values are simply assigned without raising an event.
	public class Metric
	{
		private double value_metric;
		public double Value
		{
			get
			{
				return value_metric;
			}
			set
			{
				value_metric = value;

			}
		}

		private string unit_metric;
		public string Unit
		{
			get
			{
				return unit_metric;
			}
			set
			{
				unit_metric = value;

			}
		}

		private int unitType_metric;
		public int UnitType
		{
			get
			{
				return unitType_metric;
			}
			set
			{
				unitType_metric = value;

			}
		}
	}

	// Note : For Metric and Imperial classes, we do not need to raise an OnPropertyChanged() event.
	// So we exclude that line from Value (set), Unit (set) and UnitType (set).
	// When we included an OnPropertyChanged() event, the JSON deserializer crashed with some bullshit message.
	// So we exclude it.  Imperial and Metric values are simply assigned without raising an event.
	public class Imperial
	{
		private int value_imperial;
		public int Value
		{
			get
			{
				return value_imperial;
			}
			set
			{
				value_imperial = value;
			}
		}

		private string unit_imperial;
		public string Unit
		{
			get
			{
				return unit_imperial;
			}
			set
			{
				unit_imperial = value;
			}
		}

		private int unittype_imperial;
		public int UnitType
		{
			get
			{
				return unittype_imperial;
			}
			set
			{
				unittype_imperial = value;
			}
		}
	}

	// We need the OnPropertyChanged() event raised for Temperature (but not Metric and Imperial properties above).
	public class Temperature : INotifyPropertyChanged
	{
		private Metric metric;
		public Metric Metric
		{
			get
			{
				return metric;
			}
			set
			{
				metric = value;
				OnPropertyChanged("Metric");
			}
		}

		private Imperial imperial;
		public Imperial Imperial
		{
			get
			{
				return imperial;
			}
			set
			{
				imperial = value;
				OnPropertyChanged("Imperial");
			}
		}

		// this causes an event to be raised everytime a property changes (due to set)
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			// checks to see if the property that has been changed has a handler associated with it
			// if so, only then do we raise an event
			// we don't want to raise an event unless there is a handler for it or we will cause a problem
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}

	// to implement INotifyPropertyChanged we need to do 2 things.
	// 1. add using System.ComponentModel namespace at the top
	// 2. implent the event handler PropertyChanged below
	// set is what makes the property change because in there is where we assign a new value
	public class AccuWeather : INotifyPropertyChanged  
	{
		//public DateTime LocalObservationDateTime { get; set; }
		//public int EpochTime { get; set; }
		//public string WeatherText { get; set; } // implemented below
		//public int WeatherIcon { get; set; }
		//public bool IsDayTime { get; set; }
		//public Temperature Temperature { get; set; }

		private DateTime localObservationDateTime;
		public DateTime LocalObservationDateTime
		{
			get
			{
				return localObservationDateTime;
			}
			set
			{
				localObservationDateTime = value;
				OnPropertyChanged("LocalObservationDateTime");
			}
		}

		private int epochTime;
		public int EpochTime
		{
			get
			{
				return epochTime;
			}
			set
			{
				epochTime = value;
				OnPropertyChanged("EpochTime");
			}
		}

		private string weathertext;
		public string WeatherText
		{
			get
			{
				return weathertext;
			}
			set
			{
				weathertext = value;
				OnPropertyChanged("WeatherText");
			}
		}

		private int weatherIcon;
		public int WeatherIcon
		{
			get
			{
				return weatherIcon;
			}
			set
			{
				weatherIcon = value;
				OnPropertyChanged("WeatherIcon");
			}
		}

		private bool isdaytime;
		public bool IsDayTime
		{
			get
			{
				return isdaytime;
			}
			set
			{
				isdaytime = value;
				OnPropertyChanged("IsDayTime");
			}
		}

		private Temperature temperature;
		public Temperature Temperature
		{
			get
			{
				return temperature;
			}
			set
			{
				temperature = value;
				OnPropertyChanged("Temperature");
			}
		}

		private string mobilelink;
		public string MobileLink
		{
			get
			{
				return mobilelink;
			}
			set
			{
				mobilelink = value;
				OnPropertyChanged("MobileLink");
			}
		}

		private string link;
		public string Link
		{
			get
			{
				return link;
			}
			set
			{
				link = value;
				OnPropertyChanged("Link");
			}
		}

		// this causes an event to be raised everytime a property changes (due to set)
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			// checks to see if the property that has been changed has a handler associated with it
			// if so, only then do we raise an event
			// we don't want to raise an event unless there is a handler for it or we will cause a problem
			if(PropertyChanged != null)
			{ 
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		// Constructor of AccuWeather Class
		// constructor should be right below all properties and events
		// but right before any other method
		public AccuWeather()
		{
			// We only want to simulate test date for display when we are testing to see if it binds properly to our XAML front end
			// We don't really want this information to be displayed to the user when the application runs for real
			// So we use DesignerProperties.DependencyObject()
			//
			// Note : We could have also done something like this (i.e. DesignerProperties stuff) from WeatherVM to check if we are in design mode. 
			// But since we are doing it here, we don't have to do it there.
			//
			// What this DependencyObject stuff will do is display it in our XAML view in Visual Studio
			// but will NOT show it when we compile & run the application (both in Debug and without Debug mode).
			if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
			{
				Temperature = new Temperature()
				{
					Imperial = new Imperial()
					{
						Value = 88,
						Unit = "F",
						UnitType = 18
					},
					Metric = new Metric()
					{
						Value = 25.8,
						Unit = "C",
						UnitType = 17
					}
				};

				WeatherText = "Cloudy";
			}
		}
	}
}
