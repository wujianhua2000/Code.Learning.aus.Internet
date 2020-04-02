using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Learning
{
    public partial class FormMain : Form
    {
        public FormMain( )
        {
            InitializeComponent( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_001_Click( object sender, EventArgs e )
        {
            Learning.TestCollection.DemoCollectionEasy( );

            return;
        }

        private void Button_002_Click( object sender, EventArgs e )
        {
            Learning.TestCollectionHith test = new TestCollectionHith();
            test.DemoDinosaurs( );

            return;
        }

        //.....................................................................
    }
}
