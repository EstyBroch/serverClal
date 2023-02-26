using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Model
{
    public class WeatherModel
    {
        public LocationModel Location { get; set; }
        public ForecastModel Forecast { get; set; }
        public CurrentModel Current { get; set; }

    }


}

