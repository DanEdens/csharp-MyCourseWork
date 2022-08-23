using System;
using System.Diagnostics;

namespace Weather
{
    public struct WeatherObservation
    {
        public DateTime TimeStamp;
        public float Barometric_Pressure;

        public static WeatherObservation Parse(string text)
        {
            var data = text.Split('\t');

            Debug.Assert(data.Length == 8);

            var timestamp = DateTime.Parse(data[(int)WeatherObservationMetrics.Date_Time].Replace("_", "-"));
            var pressure = float.Parse(data[(int)WeatherObservationMetrics.Barometric_Pressure]);

            return new WeatherObservation()
            {
                TimeStamp = timestamp,
                Barometric_Pressure = pressure
            };
        }

        public static bool TryParse(string text, out WeatherObservation wo)
        {
            throw new NotImplementedException();
        }
    }
}
