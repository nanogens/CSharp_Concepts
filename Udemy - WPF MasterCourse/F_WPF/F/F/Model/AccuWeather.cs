using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	public class MeasuringUnit
	{
		public double Value { get; set; }
		public string Unit { get; set; }
		public int UnitType { get; set; }
	}

	public class Temperature
	{
		public MeasuringUnit Metric { get; set; }
		public MeasuringUnit Imperial { get; set; }
	}

	public class AccuWeather
	{
		public DateTime LocalObservationDateTime { get; set; }
		public int EpochTime { get; set; }
		public string WeatherText { get; set; }
		public int WeatherIcon { get; set; }
		public bool IsDayTime { get; set; }
		public Temperature Temperature { get; set; }
		//public string MobileLink { get; set; }
		//public string Link { get; set; }
	}
}
