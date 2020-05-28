using System;

namespace CPN.Model
{
    public class WeatherForecast
    {
        public string DateFormatted { get; set; }

        public string Summary { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

        public DateTime Date { get; set; }
    }
}
