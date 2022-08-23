using CodeClinic;
using LiveCharts;
using LiveCharts.Configurations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dashboard
{
    /// <summary>
    /// Interaction logic for ConstantChangesChart.xaml
    /// </summary>
    public partial class ConstantChangesChart : UserControl, INotifyPropertyChanged
    {
        private static long tickZero = DateTime.Parse("2018-01-01T08:00:00Z").Ticks;

        public Func<double, string> X_Axis_LabelFormatter { get; set; } = d => TimeSpan.FromTicks((long)d - tickZero).TotalSeconds.ToString();

        public ConstantChangesChart()
        {
            InitializeComponent();

            lsEfficiency.Configuration = Mappers.Xy<FactoryTelemetry>().X(ft => ft.TimeStamp.Ticks).Y(ft => ft.Efficiency);

            lsPulse.Configuration = Mappers.Xy<FactoryTelemetry>().X(ft => ft.TimeStamp.Ticks).Y(ft => ft.Pulse);

            lsRed.Configuration = Mappers.Xy<FactoryTelemetry>().X(ft => ft.TimeStamp.Ticks).Y(ft => ft.Red);
            lsGreen.Configuration = Mappers.Xy<FactoryTelemetry>().X(ft => ft.TimeStamp.Ticks).Y(ft => ft.Green);
            lsBlue.Configuration = Mappers.Xy<FactoryTelemetry>().X(ft => ft.TimeStamp.Ticks).Y(ft => ft.Blue);


            DataContext = this;
        }

        public ChartValues<FactoryTelemetry> ChartValues { get; set; } = new ChartValues<FactoryTelemetry>();

        private bool readingData = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!readingData)
            {
                Task.Factory.StartNew(ReadData);
            }
            readingData = !readingData;
        }

        private void ReadData()
        {
            // TODO: Populate the collection ChartValues

            string filename = @"..\..\..\..\..\dashBoardData.csv";

            foreach (var ft in FactoryTelemetry.Load(filename))
            {
                if (!readingData)
                    return;

                ChartValues.Add(ft);

                this.EngineEfficiency = ft.Efficiency;

                AdjustAxis(ft.TimeStamp.Ticks);

                if (ChartValues.Count > 30)
                    ChartValues.RemoveAt(0);

                Thread.Sleep(50);
            }

        }
        public double AxisStep { get; set; } = TimeSpan.FromSeconds(5).Ticks;
        public double AxisUnit { get; set; } = TimeSpan.FromSeconds(1).Ticks;

        private double _axisMax = tickZero + TimeSpan.FromSeconds(30).Ticks;
        public double AxisMax { get => _axisMax; set { _axisMax = value; OnPropertyChanged(nameof(AxisMax)); } }

        private double _axisMin = tickZero;
        public double AxisMin { get => _axisMin; set { _axisMin = value; OnPropertyChanged(nameof(AxisMin)); } }

        private void AdjustAxis(long ticks)
        {
            var width = TimeSpan.FromSeconds(30).Ticks;

            AxisMin = (ticks -tickZero < width) ? tickZero : ticks-width;
            AxisMax = (ticks - tickZero < width) ? tickZero + width : ticks;
        }

        private double _EngineEfficiency = 65;


        public double EngineEfficiency
        {
            get
            {
                return _EngineEfficiency;
            }
            set
            {
                _EngineEfficiency = value;
                OnPropertyChanged(nameof(EngineEfficiency));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
