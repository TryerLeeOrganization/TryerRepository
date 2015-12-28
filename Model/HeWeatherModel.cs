using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HeWeatherModel
    {
        public int aqi { get; set; }
        public int basic { get; set; }
        public int daily_forecast { get; set; }
        public int hourly_forecast { get; set; }
        public int now { get; set; }
        public int status { get; set; }
        public int suggestion { get; set; }
    }
}
