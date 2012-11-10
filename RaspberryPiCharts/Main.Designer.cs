﻿namespace RaspberryPiCharts
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.TemperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.CpuLabel = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.SetEndpointMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureChart)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CpuChart
            // 
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisY.Interval = 10D;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.CpuChart.ChartAreas.Add(chartArea3);
            this.CpuChart.Location = new System.Drawing.Point(-33, 3);
            this.CpuChart.Name = "CpuChart";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.RoyalBlue;
            series3.Name = "Cpu Usage";
            this.CpuChart.Series.Add(series3);
            this.CpuChart.Size = new System.Drawing.Size(665, 256);
            this.CpuChart.TabIndex = 0;
            this.CpuChart.Text = "CpuChart";
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // TemperatureChart
            // 
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.MaximumAutoSize = 80F;
            chartArea4.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX2.LineWidth = 0;
            chartArea4.AxisY.Interval = 10D;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea4.Name = "ChartArea1";
            this.TemperatureChart.ChartAreas.Add(chartArea4);
            this.TemperatureChart.Location = new System.Drawing.Point(-33, 252);
            this.TemperatureChart.Name = "TemperatureChart";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.RoyalBlue;
            series4.Name = "Temperature";
            this.TemperatureChart.Series.Add(series4);
            this.TemperatureChart.Size = new System.Drawing.Size(665, 256);
            this.TemperatureChart.TabIndex = 1;
            this.TemperatureChart.Text = "chart1";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.BackColor = System.Drawing.Color.White;
            this.TemperatureLabel.Location = new System.Drawing.Point(34, 252);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(83, 13);
            this.TemperatureLabel.TabIndex = 2;
            this.TemperatureLabel.Text = "Temperature (C)";
            // 
            // CpuLabel
            // 
            this.CpuLabel.AutoSize = true;
            this.CpuLabel.BackColor = System.Drawing.Color.White;
            this.CpuLabel.Location = new System.Drawing.Point(34, 3);
            this.CpuLabel.Name = "CpuLabel";
            this.CpuLabel.Size = new System.Drawing.Size(80, 13);
            this.CpuLabel.TabIndex = 3;
            this.CpuLabel.Text = "CPU Usage (%)";
            // 
            // MainMenu
            // 
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetEndpointMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 502);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(617, 24);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "menuStrip1";
            // 
            // SetEndpointMenuItem
            // 
            this.SetEndpointMenuItem.Name = "SetEndpointMenuItem";
            this.SetEndpointMenuItem.Size = new System.Drawing.Size(86, 20);
            this.SetEndpointMenuItem.Text = "Set endpoint";
            this.SetEndpointMenuItem.Click += new System.EventHandler(this.setEndpointToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 526);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.CpuLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.TemperatureChart);
            this.Controls.Add(this.CpuChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.Text = "Raspberry Pi Charts";
            ((System.ComponentModel.ISupportInitialize)(this.CpuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureChart)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CpuChart;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart TemperatureChart;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label CpuLabel;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SetEndpointMenuItem;
    }
}
