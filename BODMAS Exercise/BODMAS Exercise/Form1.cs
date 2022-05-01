using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BODMAS_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            int vNum1;
            int vNum2;
            int vNum3;
            int vAns;

            vNum1 = int.Parse(Num1TextBox.Text);
            vNum2 = int.Parse(Num2TextBox.Text);
            vNum3 = int.Parse(Num3TextBox.Text);

            vAns = ((vNum1 * vNum2) + vNum3) * 2;
            AnsLabel.Text = vAns.ToString(); //converts vAns to a string to be displayed becasue labels display stings only

        }
    }
}
