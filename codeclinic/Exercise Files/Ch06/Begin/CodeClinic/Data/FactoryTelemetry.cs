using System;
using System.Collections.Generic;
using System.IO;

namespace CodeClinic
{
    public class FactoryTelemetry
    {
        public DateTime TimeStamp { get; set; }
        public double Pulse { get; set; }
        public double Efficiency { get; set; }
        public double Red { get; set; }
        public double Blue { get; set; }
        public double Green { get; set; }

        public static bool TryParse(string line, out FactoryTelemetry ft)
        {
            var data = line.Split(',');

            if (data.Length == 6 &&
                DateTime.TryParse(data[0], out DateTime timestamp) &&
                double.TryParse(data[1], out double pulse) &&
                double.TryParse(data[2], out double engineEfficiency) &&
                double.TryParse(data[3], out double red) &&
                double.TryParse(data[4], out double blue) &&
                double.TryParse(data[5], out double green))
            {
                ft = new FactoryTelemetry()
                {
                    TimeStamp = timestamp,
                    Pulse = pulse,
                    Efficiency = engineEfficiency,
                    Red = red,
                    Blue = blue,
                    Green = green
                };
                return true;
            }
            else
            {
                ft = null;
                return false;
            }
        }

        public static IEnumerable<FactoryTelemetry> Load(string filename)
        {
            using (var sr = new StreamReader(filename))
            {
                sr.ReadLine(); // ignore headers

                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (FactoryTelemetry.TryParse(line, out FactoryTelemetry ft))
                    {
                        yield return ft;
                    }
                }
            }
        }
    }
}