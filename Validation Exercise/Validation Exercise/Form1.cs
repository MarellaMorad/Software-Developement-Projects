using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validation_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CalcAge(int vPassed)
        {
            return DateTime.Now.Year - vPassed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vYOB = textBox1.Text;
            int vYOBInt;

            bool vCheckIntType = int.TryParse(vYOB, out vYOBInt);

            if (string.IsNullOrEmpty(vYOB))
            {
                label1.Text = "Please enter a YOB";
            }
            else if (vCheckIntType == false)
            {
                label1.Text = "Please enter a valid integer.";
            }
            else if (vYOBInt < 1850 || (vYOBInt) > DateTime.Now.Year)
            {
                label1.Text = "Please enter a valid year between 1850 and 2018";
            }
            else
            {
                label1.Text = "Valid Year entered";
                label2.Text = CalcAge(vYOBInt).ToString();
            }
        }
    }
}
