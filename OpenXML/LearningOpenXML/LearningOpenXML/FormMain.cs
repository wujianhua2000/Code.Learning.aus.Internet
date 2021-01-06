using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace LearningOpenXML
{
    public partial class FormMain : Form
    {
        public FormMain( )
        {
            InitializeComponent( );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEasyTable_Click( object sender, EventArgs e )
        {
            TestEasyTable easytab = new TestEasyTable( );
            easytab.MakeWord( );
            
            MessageBox.Show( "Alles in Ordnung!!!" );
            
            Process.Start( "explorer.exe", easytab.NamePath );
            
            this.Close( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonParagraph_Click( object sender, EventArgs e )
        {
            TestMoreParagraph test = new TestMoreParagraph( );

            test.TestDocx( );

            MessageBox.Show( "Alles in Ordnung!!!" );

            Process.Start( "explorer.exe", test.NamePath );

            this.Close( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCalcB24AC_Click( object sender, EventArgs e )
        {
            TestFormula_B2_4AC test = new TestFormula_B2_4AC( );

            test.TestDocx( );

            MessageBox.Show( "Alles in Ordnung!!!" );
            
            Process.Start( "explorer.exe", test.NamePath );

            this.Close( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnchorRCpressure_Click( object sender, EventArgs e )
        {
            TestAnchorRCpressure test = new TestAnchorRCpressure( );

            test.TestDocx( );

            MessageBox.Show( "Alles in Ordnung!!!" );

            Process.Start( "explorer.exe", test.NamePath );

            this.Close( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFormula_2_Click( object sender, EventArgs e )
        {
            TestFormula_2 test = new TestFormula_2( );
            test.TestDocx( );

            MessageBox.Show( "Alles in Ordnung!!!" );

            Process.Start( "explorer.exe", test.NamePath );

            this.Close( );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSQRT_34_Click( object sender, EventArgs e )
        {
            TestFormula_SQRT34 test = new TestFormula_SQRT34( );
            test.TestDocx( );

            MessageBox.Show( "Alles in Ordnung!!!" );
            Process.Start( "explorer.exe", test.NamePath );

            this.Close( );
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMoreLineFormula_Click( object sender, EventArgs e )
        {
            TestFormula_2lines test = new TestFormula_2lines( );
            test.TestDocx( );

            MessageBox.Show( "Alles in Ordnung!!!" );
            Process.Start( "explorer.exe", test.NamePath );

            this.Close( );
            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTable_Texts_Click( object sender, EventArgs e )
        {
            TestTable_none test = new TestTable_none( );
            test.TestDocx( );

            MessageBox.Show( "Alles in Ordnung!!!" );
            Process.Start( "explorer.exe", test.NamePath );

            this.Close( );
            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShowXlsx_Click( object sender, EventArgs e )
        {
            if ( this.DialogFile.ShowDialog( ) != System.Windows.Forms.DialogResult.OK ) return;

            string namefile = this.DialogFile.FileName;

            TestReadingExcelCells test = new TestReadingExcelCells( );

            string namepath = "d:\\123-test-openxml";
            string result = namepath + "\\excel-text-lines.csv";

            test.ReadAsDataTable( namefile );
            test.SaveInto( result );

            MessageBox.Show( "Alles in Ordnung!!!" );

            Process.Start( "explorer.exe", namepath );

            this.Close( );

            return;
        }

        //.....................................................................
    }
}
