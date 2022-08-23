using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicalInstrument
{
    public partial class Form1 : Form
    {
        SignalGenerator sine = new SignalGenerator()
        {
            Type = SignalGeneratorType.Sin,
            Gain = 0.2
        };
        WaveOutEvent player = new WaveOutEvent();

        public Form1()
        {
            InitializeComponent();

            player.Init(sine);

            trackFrequency.ValueChanged += (s, e) => sine.Frequency = trackFrequency.Value;
            trackFrequency.Value = 600;

            trackVolume.ValueChanged += (s,e) => player.Volume = trackVolume.Value / 100F;
            trackVolume.Value = 50;

        }

        private System.Drawing.Point CursorPositionOnMouseDown;
        private bool ButtonIsDown = false;
        private void TheMouseDown(object sender, MouseEventArgs e)
        {
            player.Play();

            CursorPositionOnMouseDown = e.Location;
            ButtonIsDown = true;
        }

        private void TheMouseUp(object sender, MouseEventArgs e)
        {
            player.Stop();
            ButtonIsDown = false;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            var dX = e.X - CursorPositionOnMouseDown.X;
            // var vol = 

            var dY = CursorPositionOnMouseDown.Y - e.Y;
            // var freq = 

            if (ButtonIsDown)
            {

            }

            Text = $"Musical Instrument! ({dX},{dY}) (vol, freq)";
        }
    }
}
