using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PropertyGrid5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            GameClassDisplayer gcd = new GameClassDisplayer();

            prpG.SelectedObject = gcd;
        }
    }
}