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
using System.Net.Sockets;
using System.Diagnostics;

namespace RaspberryPiCharts
{
    public partial class Main : Form
    {
        public class ResponseObject
        {
            public float cpu;
            public float temperature;
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

            if (Endpoint.Contains("tcp0://") || Endpoint.Contains("tcp1://")) {
                ConnectToServer();
            }
        }

        public void SetEndpointDialog(bool Reset = false)
        {
            string OldEndpoint = Endpoint;
            if (Reset) 
            {
                Endpoint = "";
            }
            string NewEndpoint = Interaction.InputBox("Set endpoint, use http:// or https:// to indicate http/https protocol. Use tcp0:// to indicate JSON over TCP or tcp1:// to indicate comma seperated over TCP", "Set endpoint", OldEndpoint);
            
            if (NewEndpoint != "" && NewEndpoint != null) {
                Endpoint = NewEndpoint;
                File.WriteAllText(EndpointFileName, Endpoint);
            }
            if (Endpoint.Contains("tcp0://") || Endpoint.Contains("tcp1://"))
            {
                ConnectToServer();
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (Endpoint != "")
            {
                try
                {
                    if (Endpoint.Contains("http://") || Endpoint.Contains("https://")) {
                        WebClient Http = new WebClient();
                        Http.DownloadStringAsync(new Uri(Endpoint));
                        Http.DownloadStringCompleted += new DownloadStringCompletedEventHandler(ResponseListener);
                    }
                }
                catch (Exception ex)
                {
                    SetEndpointDialog(true);
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
                ResponseObject Object = JsonConvert.DeserializeObject<ResponseObject>(Response);

                AddDataPoints(Object);
            }
            catch (Exception)
            {

            }
        }

        public void AddDataPoints (ResponseObject Object)
        {
            try
            {
                CpuMenuItem.Text = "CPU: " + Object.cpu.ToString() + "%";
                Main.ActiveForm.Invoke(new Action(delegate()
                {
                    CpuChart.Series[0].Points.AddXY(IncrementalX, Math.Min(Object.cpu, (float)100));
                }));
            }
            catch { }

            try
            {
                TemperatureMenuItem.Text = "Temperature: " + Object.temperature.ToString() + "C";
                Main.ActiveForm.Invoke(new Action(delegate()
                {
                    TemperatureChart.Series[0].Points.AddXY(IncrementalX, Object.temperature);
                    IncrementalX++;
                }));
            }
            catch { }
            
            Main.ActiveForm.Invoke(new Action(delegate()
            {
                if (CpuChart.ChartAreas[0].AxisX.Maximum > CpuChart.ChartAreas[0].AxisX.ScaleView.Size)
                    CpuChart.ChartAreas[0].AxisX.ScaleView.Scroll(CpuChart.ChartAreas[0].AxisX.Maximum);

                if (TemperatureChart.ChartAreas[0].AxisX.Maximum > TemperatureChart.ChartAreas[0].AxisX.ScaleView.Size)
                    TemperatureChart.ChartAreas[0].AxisX.ScaleView.Scroll(TemperatureChart.ChartAreas[0].AxisX.Maximum);
            }));
        }

        private void SetEndpointMenuItem_Click(object sender, EventArgs e)
        {
            SetEndpointDialog();
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
                FancifyMenuItem.Text = "Borify...";
            }
            else
            {
                CpuChart.Series[0].Palette = OldPalette;
                TemperatureChart.Series[0].Palette = OldPalette;
                FancifyMenuItem.Text = "Fancify!";
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox NewAboutBox = new AboutBox();
            NewAboutBox.Show();
        }

          private TcpClient tcpClient = null;

         public void ConnectToServer()
         {
                try
               {
                tcpClient = new TcpClient(AddressFamily.InterNetwork);

                IPAddress[] remoteHost = Dns.GetHostAddresses("192.168.0.192");
               
                //Start the async connect operation           

                tcpClient.BeginConnect(remoteHost, 5000, new
                              AsyncCallback(ConnectCallback), tcpClient);

                }
                catch (Exception ex)
                {
                 
                }
         }
       

        private void ConnectCallback(IAsyncResult result)
        {                       
             try
             {
              //We are connected successfully.

               NetworkStream networkStream = tcpClient.GetStream();

               byte[] buffer = new byte[tcpClient.ReceiveBufferSize];

              //Now we are connected start asyn read operation.

               networkStream.BeginRead(buffer, 0, buffer.Length, ReadCallback, buffer);
              }
              catch(Exception ex)
              {
                   
               }
          }
       

           
            /// Callback for Read operation
            private void ReadCallback(IAsyncResult result)
            {     
   
            NetworkStream networkStream;

            try
            {

                networkStream = tcpClient.GetStream();   
         
            }

            catch
            {
                return;

            }         

            byte[] buffer = result.AsyncState as byte[];
            


            string Data = ASCIIEncoding.ASCII.GetString(buffer, 0, networkStream.EndRead(result));

            try
            {
                
                ResponseObject Object = JsonConvert.DeserializeObject<ResponseObject>(Data);

                if (Object.temperature != null || Object.cpu != null)
                {
                    AddDataPoints(Object);
                }
            }
            catch (Exception e)
            {

            }

            //Then start reading from the network again.

            networkStream.BeginRead(buffer, 0, buffer.Length, ReadCallback, buffer);

        }
    }
}
