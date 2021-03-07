using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PropertyGrid2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DemoClass pgdc = new DemoClass();
            prpG.SelectedObject = pgdc;
        }

        private void prpG_Click(object sender, EventArgs e)
        {

        }
    }
}