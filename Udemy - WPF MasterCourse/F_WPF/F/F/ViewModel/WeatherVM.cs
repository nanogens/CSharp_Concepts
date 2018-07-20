using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// added this in 
using F.Model;

namespace F.ViewModel
{
	public class WeatherVM
	{
		public CurrentConditions Weather { get; set; }

		// Initialize the Weather properties to our default values (which we set in CurrentConditions class constructor - near the bottom of the class)
		public WeatherVM()
		{
			Weather = new CurrentConditions();
		}
	}
}
