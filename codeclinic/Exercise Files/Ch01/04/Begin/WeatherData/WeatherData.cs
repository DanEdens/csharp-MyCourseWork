using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Weather
{
    public class WeatherData
    {
        public static IEnumerable<WeatherObservation> ReadRange(
            TextReader text,
            DateTime? start = null,
            DateTime? end = null,
            Action<string> errorHandler = null)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<WeatherObservation> ReadAll(TextReader text, Action<string> errorHandler = null)
        {
            throw new NotImplementedException();
        }
    }
}
