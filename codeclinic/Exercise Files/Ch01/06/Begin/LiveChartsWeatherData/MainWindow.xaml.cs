using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.IO;
using System.Windows;
using Weather;

namespace LiveChartsWeatherData
{
    public partial class MainWindow : Window
    {
        private static string filename = @"c:\users\booth01-mgr2\Desktop\CodeClinic\1 - Pond Oreille\Environmental_Data_Deep_Moor_2012.txt";

        public MainWindow()
        {
            InitializeComponent();

            // Add LineSeries

            // ChartValues of WeatherObservation

            // Mapping Functions from raw values to doubles for Axis (X & Y)

            // Series Collection containing the LineSeries

            DataContext = this; // for databinding
        }

        private static void LoadData(ChartValues<WeatherObservation> values)
        {
            var start = DateTime.Parse("2012-01-02 00:00:00");
            var end = DateTime.Parse("2012-01-02 17:00:00");

            using (var text = new StreamReader(filename))
            {
                text.ReadLine();

                var woValues = WeatherData.ReadRange(text, start, end);

                values.AddRange(woValues);
            }
        }

        public SeriesCollection MySeriesCollection { get; set; }

        public Func<double, string> X_Label_Formatter => (d) => (new DateTime((long)d)).ToString("yyyy-MM:dd HH:mm:ss");
        public Func<double, string> Y_Label_Formatter => (d) => d.ToString("###.00");
    }
}
