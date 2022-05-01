using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excersie_4___2nd_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double vNum1;
            double vNum2;
            double vNum3;
            double vOut1;
            double vOut2;
            double vOut3;

            vNum1 = double.Parse(textBox1.Text);
            vNum2 = double.Parse(textBox2.Text);
            vNum3 = double.Parse(textBox3.Text);

            vOut1 = Math.Round((vNum1 + vNum2) * vNum3, 2);
            vOut2 = Math.Round((vNum1 * vNum2) + (vNum2 * vNum3), 2);
            vOut3 = Math.Round((vNum1 + vNum2) / vNum3, 2);

            FirstOutPut.Text = vOut1.ToString();
            SecondOutPut.Text = vOut2.ToString();
            ThirdOutPut.Text = vOut3.ToString();
        }
    }
}
