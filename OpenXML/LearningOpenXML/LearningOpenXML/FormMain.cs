using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

            return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonParagraph_Click( object sender, EventArgs e )
        {
            TestMoreParagraph test = new TestMoreParagraph( );

            test.Process( );

            MessageBox.Show( "Alles in Ordnung!!!" );

            return;
        }
    }
}
