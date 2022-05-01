using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Tools___Exercise_10___Currency_Converter
{
    public partial class Form1 : Form
    {
        string vChoice;
        double vConverted;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            Convert();
        }

        void Convert()
        {
            double AUAmount = double.Parse(AUDTxtBox.Text);

            if (USRadioBtn.Checked == true)
            {
                vChoice = "US";
            }
            else if (UKRadioBtn.Checked == true)
            {
                vChoice = "UK";
            }
            else if (EURadioBtn.Checked == true)
            {
                vChoice = "EU";
            }
            else
            {
                MessageBox.Show("Please choose a currency to convert into");
            }

            if (vChoice == "US")
            {
                vConverted = AUAmount * 0.70;
                ConvertDisplayLabel.Text = ("$" + vConverted).ToString();
            }
            else if (vChoice == "UK")
            {
                vConverted = AUAmount * 0.54;
                ConvertDisplayLabel.Text = ("£" + vConverted).ToString();
            }
            else if (vChoice == "EU")
            {
                vConverted = AUAmount * 0.63;
                ConvertDisplayLabel.Text = ("€" + vConverted).ToString();
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
