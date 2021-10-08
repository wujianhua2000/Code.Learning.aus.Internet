using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace Hans.Opxm
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
        /// easy paragraph
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
            TestDocxMathAnchorRCpressure test = new TestDocxMathAnchorRCpressure( );

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
            TestTable_AllesGut test = new TestTable_AllesGut( );
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
        /// <summary>
        /// ButtonMontageHeading0103_Click is best
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDocxHeading01_Click( object sender, EventArgs e )
        {
            TestDocxHeading01 test = new TestDocxHeading01( );
            test.TestDocx( );

            MessageBox.Show( "Alles in Ordnung!!!" );
            Process.Start( "explorer.exe", test.NamePath );

            this.Close( );
            return;
        }

        //.....................................................................
        /// <summary>
        /// 使用  H1-list-style.docx
        /// 
        /// 列出全部 stylex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonListStyles_Click( object sender, EventArgs e )
        {
            OpenDocxBase test = new  OpenDocxBase( );
            test.OpenExistDocx( "D:\\123-test-openxml\\h1.docx", false );

            //MessageBox.Show( "Alles in Ordnung!!!" );
            Process.Start( "explorer.exe", test.NamePath );

            this.Close( );
            return;
        }

        //.....................................................................
        /// <summary>
        /// 最好的一个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMontageHeading0103_Click( object sender, EventArgs e )
        {
            TestDocxNumbering0105 test = new TestDocxNumbering0105( );
            test.TestDocx( );
            
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
        private void ButtonCreateSheet01_Click( object sender, EventArgs e )
        {
            TestXlsxEmployees test = new TestXlsxEmployees( );
            test.TestXlsx( );

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
        private void ButtonEmptySheet_Click( object sender, EventArgs e )
        {
            TestXlsxEmptySheet test = new TestXlsxEmptySheet( );
            test.TestXlsx( );

            Process.Start( "explorer.exe", test.NamePath );

            this.Close( );
            return;
        }

        //.....................................................................
        /// <summary>
        /// 可以废弃了，以 Test Docx Table Alles Gut 为准。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDocxTable_Click( object sender, EventArgs e )
        {
            TestDocxTable easytab = new TestDocxTable( );
            easytab.TestDocx( );

            MessageBox.Show( "Alles in Ordnung!!!" );

            Process.Start( "explorer.exe", easytab.NamePath );

            this.Close( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSectionParagraph_Click( object sender, EventArgs e )
        {
            TestDocxSectionHeader easytab = new TestDocxSectionHeader( );
            easytab.TestDocx( );

            MessageBox.Show( "Alles in Ordnung!!!" );

            Process.Start( "explorer.exe", easytab.NamePath );

            this.Close( );
        }

        //.....................................................................
    }
}
