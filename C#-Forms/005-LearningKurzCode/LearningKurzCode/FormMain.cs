using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LearningKurzCode
{
    public partial class FormMain : Form
    {
        public FormMain( )
        {
            InitializeComponent( );
        }

        //.....................................................................
        /// <summary>
        /// 一个极佳的 LINQ GROUP BY 的例子
        /// 
        /// https://www.completecsharptutorial.com/linqtutorial/groupby-singlekey-multikey-sorting-grouping-linq-csharp-tutorial.php
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGroupBy_Click( object sender, EventArgs e )
        {
            KurzCode20200402.LingGroupBy20200402 test = new KurzCode20200402.LingGroupBy20200402( );

            //test.TestSingleKeyGrouping( );
            //test.TestMultiKeyGrouping( );
            //test.TestGroupingSorting( );

            return;
        }

        //.....................................................................
    }
}
