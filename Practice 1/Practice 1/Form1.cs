using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowButton.Visible = false;
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            PicBox.Visible = false;
            ShowButton.Visible = true;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PicBox.Visible = true;
        }
    }
}
