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

namespace TestChart
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent( );
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            //this.TestChartPets( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private void TestChartPets( )
        {
            this.chart1.Titles.Clear( );
            this.chart1.Series.Clear( );

            // Data arrays.
            string[ ] seriesArray = { "Cats 猫", "Dogs 狗" };
            int[ ] pointsArray = { 1, 2 };

            // Set palette.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart1.Titles.Add( "Pets 宠物" );

            // Add series.
            for ( int i = 0; i < seriesArray.Length; i++ )
            {
                // Add series.
                Series series = this.chart1.Series.Add( seriesArray[ i ] );

                // Add point.
                series.Points.Add( pointsArray[ i ] );
            }

            string imagename = "d:\\123-temp\\test-cs-chart-pets.png";
            
            this.chart1.SaveImage( imagename, ChartImageFormat.Png );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private void SplineChartExample( )
        {
            this.chart1.Series.Clear( );
            this.chart1.Titles.Clear( );

            this.chart1.Titles.Add( "Total Income" );

            Series series = this.chart1.Series.Add( "Total Income" );

            series.ChartType = SeriesChartType.Spline;
            //series.LabelAngle = 90;

            series.Points.AddXY( "September", 100 );
            series.Points.AddXY( "Obtober", 300 );
            series.Points.AddXY( "November", 800 );
            series.Points.AddXY( "December", 200 );
            series.Points.AddXY( "January", 600 );
            series.Points.AddXY( "February", 400 );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click( object sender, EventArgs e )
        {
            this.TestChartPets( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click( object sender, EventArgs e )
        {
            this.SplineChartExample( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// http://www.tutorialspanel.com/bind-chart-control-using-c-linq/
        /// 
        /// </summary>
        private DataTable dataTable = new DataTable( );

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private void BindingGrid( )
        {
            //int i;
            
            //object[ ] array = new object[ 3 ];

            dataTable.Columns.Add( "ID" );
            dataTable.Columns.Add( "Name" );
            dataTable.Columns.Add( "Department" );
            dataTable.Columns.Add( "Job title" );

            dataTable.Rows.Add( 1, "Steve", "IT", "IT Specialist" );
            dataTable.Rows.Add( 2, "Russ", "Engineering", "Software Engineer" );
            dataTable.Rows.Add( 3, "Ron", "IT", "Data Scientist" );
            dataTable.Rows.Add( 4, "Peter", "IT", "Programmer" );
            dataTable.Rows.Add( 5, "Jasone", "IT", "Programmer" );
            dataTable.Rows.Add( 6, "Ken", "Administration", "HR Specialist" );

            DataGrid.DataSource = dataTable;

            return;
        } 

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private void BindingChart( )
        {
            string[ ] seriesArray 
                = dataTable.AsEnumerable( )
                    .Select( rw => rw.Field<string>( "Department" ) )
                    .Distinct( ).ToArray( );

            Console.WriteLine( string.Join( ", ", seriesArray ) );
            
            // Set palette.
            this.chart1.Palette = System.Windows.Forms.DataVisualization
                                        .Charting
                                        .ChartColorPalette
                                        .SemiTransparent;
            
            this.chart1.Titles.Clear( );
            this.chart1.Series.Clear( );

            // Set title.
            this.chart1.Titles.Add( "Number of employees per Department" );
            
            // Add series.
            for ( int i = 0; i < seriesArray.Length; i++ )
            {
                Series series = this.chart1.Series.Add( seriesArray[ i ] );

                int count = ( from DataRow row in dataTable.Rows where ( string ) row[ "Department" ] == seriesArray[ i ] select row ).Count( );
                
                series.Points.Add( count );
            }
            
            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click( object sender, EventArgs e )
        {
            this.BindingGrid( );
            this.BindingChart( );

            return;
        }

        private void button4_Click( object sender, EventArgs e )
        {
            Series s1 = new Series( );
            Series s2 = new Series( );
            
            Random random = new Random( );
         
            for ( int i = 1; i < 13; i++ )
            {
                s1.Points.AddXY( i, random.Next( 20, 30 ) );
                s2.Points.AddXY( i, random.Next( 10, 30 ) );
            }
            
            chart1.Series.Add( s1 );
            chart1.Series.Add( s2 );

            chart1.ChartAreas[ 0 ].AxisX.MajorGrid.LineColor = Color.Green;
            
            DateTime dataTime = DateTime.Parse( "8:30" );

            // 这里i从1开始，如果是0，标签不显示，不明白为什么             
            //
            for ( int i = 1; i < 26; i++ )
            {
                //奇数刻度位置放标签，这样吧柱形图包在刻度之间      
                //
                if ( i % 2 == 1 )
                {
                    CustomLabel label = new CustomLabel( );

                    label.Text = dataTime.ToShortTimeString( );
                    label.ToPosition = i;
                    
                    chart1.ChartAreas[ 0 ].AxisX.CustomLabels.Add( label );
                    
                    label.GridTicks = GridTickTypes.Gridline;
                    
                    dataTime = dataTime.AddHours( 1 );
                }

            }

            return;
        }

        //.....................................................................
    }
}
