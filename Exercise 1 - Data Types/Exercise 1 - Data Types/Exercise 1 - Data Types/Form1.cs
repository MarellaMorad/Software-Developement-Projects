using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1___Data_Types
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            int Int1 = int.Parse(IntNum1.Text);
            int Int2 = int.Parse(IntNum2.Text);
            int IntAns = Int1 + Int2;
            IntAnsLabel.Text = IntAns.ToString();

            double Double1 = double.Parse(DoubleNum1.Text);
            double Double2 = double.Parse(DoubleNum2.Text);
            double DoubleAns = Double1 + Double2;
            DoubleAnsLabel.Text = DoubleAns.ToString();

            float Float1 = float.Parse(FPNum1.Text);
            float Float2 = float.Parse(FPNum2.Text);
            float FloatAns = Float1 + Float2;
            FPAnsLabel.Text = FloatAns.ToString();

            string EmailStarter = NameTextBox.Text;
            string Email = EmailStarter + "@gmail.com";
            EmailLabel.Text = Email;

            bool Boolean = false;

            if (BoolTextBox.Text == "T" || BoolTextBox.Text == "t")
            {
                Boolean = true;
            }

            if (Boolean == true)
            {
                BoolAnsLabel.Text = "You are a Member";
            }
            else
            {
                BoolAnsLabel.Text = "You are NOT a Member";
            }

        
                
        }
    }
}
