using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

using System.Windows.Forms.DataVisualization.Charting;

namespace TestChartLog10
{
    public partial class FormMain : Form
    {
        public FormMain( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.PlotChart( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        void PlotChart( )
        {
            Random myRandom = new Random( );

            this.InitChart( );

            for ( int i = 0; i < 100; i++ )
            {
                chart1.Series[ "BV" ].Points.AddXY( i + 1, 10 * myRandom.NextDouble( ) );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// https://social.msdn.microsoft.com/forums/vstudio/en-US/9e658839-73c7-4244-abad-747b44fa9a41/problem-with-log10-scale-display-of-point-c-class-chart
        /// 
        /// </summary>
        private void InitChart( )
        {
            chart1.ChartAreas.Clear( );
            chart1.Series.Clear( );
            chart1.Titles.Clear( );

            ChartArea chartArea = new ChartArea( "LogChartArea" );

            //chartArea.AxisX.Minimum = 0.080;
            //chartArea.AxisY.Minimum = 0.080;

            chartArea.AxisX.Maximum = 200.00;
            //chartArea.AxisY.Maximum = 120.00;

            //  Remove X-axis grid lines
            //  Remove Y-axis grid lines
            //
            chartArea.AxisX.MajorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.Enabled = true;

            //  MinorGrid off by default
            //
            chartArea.AxisX.MinorGrid.Enabled = true;
            chartArea.AxisY.MinorGrid.Enabled = true;

            //  Chart Area Back Color
            //
            chart1.ChartAreas.Add( chartArea );

            Series series1 = new Series( "BV" );

            chart1.Series.Add( series1 );

            series1.MarkerStyle = MarkerStyle.Circle;
            series1.LegendText = "damping 2%";

            series1.ChartType = SeriesChartType.Point;
            series1.ChartType = SeriesChartType.Line;
            series1.MarkerSize = 2;

            chart1.BorderColor = Color.SteelBlue;
            chart1.ChartAreas[ 0 ].BorderColor = Color.SteelBlue;

            string naming = "LogChartArea";

            chart1.ChartAreas[ naming ].AxisX.Title = "频率 Frequency（Hz）";
            chart1.ChartAreas[ naming ].AxisY.Title = "加速度 Acceleration（g）";

            chart1.ChartAreas[ naming ].AxisX.TitleFont = new Font( "微软雅黑", 10, FontStyle.Regular );
            chart1.ChartAreas[ naming ].AxisY.TitleFont = new Font( "微软雅黑", 10, FontStyle.Regular );

            chart1.ChartAreas[ naming ].AxisX.MajorGrid.Interval = 1;
            chart1.ChartAreas[ naming ].AxisX.MajorGrid.LineWidth = 2;
            
            chart1.ChartAreas[ naming ].AxisX.MinorGrid.Interval = 1;
            chart1.ChartAreas[ naming ].AxisX.MinorGrid.LineWidth = 1;

            chart1.ChartAreas[ naming ].AxisY.MajorGrid.Interval = 1;
            chart1.ChartAreas[ naming ].AxisY.MajorGrid.LineWidth = 2;

            chart1.ChartAreas[ naming ].AxisY.MinorGrid.Interval = 1;
            chart1.ChartAreas[ naming ].AxisY.MinorGrid.LineWidth = 1;

            chart1.ChartAreas[ naming ].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            chart1.ChartAreas[ naming ].AxisX.MajorGrid.LineColor = Color.SkyBlue;

            chart1.ChartAreas[ naming ].AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Solid;
            chart1.ChartAreas[ naming ].AxisX.MinorGrid.LineColor = Color.SlateGray;  

            chart1.ChartAreas[ naming ].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            chart1.ChartAreas[ naming ].AxisY.MajorGrid.LineColor = Color.SkyBlue;
            //chart1.ChartAreas[ naming ].AxisY.LineColor = Color.SkyBlue;

            chart1.ChartAreas[ naming ].AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Solid;
            chart1.ChartAreas[ naming ].AxisY.MinorGrid.LineColor = Color.SlateGray;  

            chart1.ChartAreas[ naming ].AxisX.MajorTickMark.Enabled = true;
            chart1.ChartAreas[ naming ].AxisY.MajorTickMark.Enabled = true;

            //chart1.ChartAreas[ naming ].AxisX.MinorTickMark.Enabled = true;
            //chart1.ChartAreas[ naming ].AxisY.MinorTickMark.Enabled = true;

            //  Base 10 is default
            //  chart1.ChartAreas["LogChartArea"].AxisX.LogarithmBase = 10;
            //  chart1.ChartAreas["LogChartArea"].AxisY.LogarithmBase = 10;
            //
            chart1.ChartAreas[ naming ].AxisX.IsLogarithmic = true;
            chart1.ChartAreas[ naming ].AxisY.IsLogarithmic = true;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click( object sender, EventArgs e )
        {
            this.InitChart( );

            string filename = @"D:\123-spectra\test-chart.txt";

            string[ ] datalines = File.ReadAllLines( filename, Encoding.Default );

            foreach ( string line in datalines )
            {
                if ( string.IsNullOrEmpty( line ) ) continue;

                string[ ] tokens = line.Split( " \t,".ToCharArray( ), 
                                               StringSplitOptions.RemoveEmptyEntries );

                if ( tokens.Length < 2 ) continue;

                double fre = Convert.ToDouble( tokens[ 0 ] );
                double acc = Convert.ToDouble( tokens[ 1 ] );

                chart1.Series[ "BV" ].Points.AddXY( fre, acc );
                //chart1.Series[ "damping 2%" ].Points.AddXY( fre, acc );
            }

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private int GapX;
        private int GapY;

        private int ButX1;
        private int ButY1;

        private int ButX2;
        private int ButY2;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load( object sender, EventArgs e )
        {
            this.GapX = this.ClientRectangle.Width - this.chart1.Width - this.chart1.Left;
            this.GapY = this.ClientRectangle.Height - this.chart1.Height - this.chart1.Top;

            this.ButX1 = this.ClientRectangle.Width - this.button1.Left;
            this.ButY1 = this.ClientRectangle.Height - this.button1.Top;

            this.ButX2 = this.ClientRectangle.Width - this.button2.Left;
            this.ButY2 = this.ClientRectangle.Height - this.button2.Top;

            return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize( object sender, EventArgs e )
        {
            this.chart1.Width = this.ClientRectangle.Width - this.GapX - this.chart1.Left;
            this.chart1.Height = this.ClientRectangle.Height -this.GapY- this.chart1.Top;

            this.button1.Left = this.ClientRectangle.Width - this.ButX1;
            this.button1.Top = this.ClientRectangle.Height - this.ButY1;

            this.button2.Left = this.ClientRectangle.Width - this.ButX2;
            this.button2.Top = this.ClientRectangle.Height - this.ButY2;

            return;
        }

        //.....................................................................
    }
}
