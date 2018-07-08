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
#endregion

namespace F.Model
{
	public class Measurement
	{
		public double Value { get; set; }
		public string Unit { get; set; }
		public int UnitType { get; set; }
	}

	public class Temperature
	{
		public Measurement Metric { get; set; }
		public Measurement Imperial { get; set; }
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
