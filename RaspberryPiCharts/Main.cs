using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Microsoft.VisualBasic;

namespace RaspberryPiCharts
{
    public partial class Main : Form
    {
        public class ResaponseObject
        {
            public float cpu;
            public float temp;
        }

        public string Endpoint = "";
        public const string EndpointFileName = "endpoint.config";
        public System.Windows.Forms.DataVisualization.Charting.ChartColorPalette OldPalette;
        public const int XSize = 30;
        public int IncrementalX = XSize;
        

        public Main()
        {
            InitializeComponent();
            if (File.Exists(EndpointFileName))
            {
                Endpoint = File.ReadAllText(EndpointFileName);
            }
            else
            {
                SetEndpointDialog();
            }
            CpuChart.ChartAreas[0].AxisY.Minimum = 0;
            CpuChart.ChartAreas[0].AxisY.Maximum = 100;
            CpuChart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
            CpuChart.ChartAreas[0].AxisX.ScaleView.Size = XSize;

            TemperatureChart.ChartAreas[0].AxisY.Minimum = 0;
            TemperatureChart.ChartAreas[0].AxisY.Maximum = 100;
            TemperatureChart.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
            TemperatureChart.ChartAreas[0].AxisX.ScaleView.Size = XSize;
        }

        public void SetEndpointDialog(bool Reset = false)
        {
            string OldEndpoint = Endpoint;
            if (Reset) 
            {
                Endpoint = "";
            }
            string NewEndpoint = Interaction.InputBox("Set endpoint", "Set endpoint", OldEndpoint);
            Console.WriteLine("H:" + NewEndpoint + ":H");
            if (NewEndpoint != "" && NewEndpoint != null) {
                Endpoint = NewEndpoint;
                File.WriteAllText(EndpointFileName, Endpoint);
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (Endpoint != "")
            {
                try
                {
                    WebClient Http = new WebClient();
                    Http.DownloadStringAsync(new Uri(Endpoint));
                    Http.DownloadStringCompleted += new DownloadStringCompletedEventHandler(ResponseListener);
                }
                catch (Exception ex)
                {
                    //SetEndpointDialog(true);
                }
            }

        }

        public void ResponseListener(Object sender, DownloadStringCompletedEventArgs e)
        {
            var webException = e.Error as WebException;
            if (webException != null && webException.Status == WebExceptionStatus.NameResolutionFailure)
                return;
            try
            {
                string Response = (string)e.Result;
                ResaponseObject Object = JsonConvert.DeserializeObject<ResaponseObject>(Response);
                
                CpuChart.Series[0].Points.AddXY(IncrementalX, Math.Min(Object.cpu, (float) 100));
                TemperatureChart.Series[0].Points.AddXY(IncrementalX, Object.temp);
                IncrementalX++;

                if (CpuChart.ChartAreas[0].AxisX.Maximum > CpuChart.ChartAreas[0].AxisX.ScaleView.Size)
                    CpuChart.ChartAreas[0].AxisX.ScaleView.Scroll(CpuChart.ChartAreas[0].AxisX.Maximum);

                if (TemperatureChart.ChartAreas[0].AxisX.Maximum > TemperatureChart.ChartAreas[0].AxisX.ScaleView.Size)
                    TemperatureChart.ChartAreas[0].AxisX.ScaleView.Scroll(TemperatureChart.ChartAreas[0].AxisX.Maximum);

            }
            catch (Exception)
            {

            }
        }

        private void setEndpointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetEndpointDialog();
        }

        private void ResetMenuItem_Click(object sender, EventArgs e)
        {
            CpuChart.Series[0].Points.Clear();
            TemperatureChart.Series[0].Points.Clear();
            CpuChart.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void FancifyMenuItem_Click(object sender, EventArgs e)
        {
            if (CpuChart.Series[0].Palette != System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel)
            {
                OldPalette = CpuChart.Series[0].Palette;
                CpuChart.Series[0].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
                TemperatureChart.Series[0].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
                FancifyMenuItem.Text = "Borify!";
            }
            else
            {
                CpuChart.Series[0].Palette = OldPalette;
                TemperatureChart.Series[0].Palette = OldPalette;
                FancifyMenuItem.Text = "Fancify!";
            }
        }
    }
}
