using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validation___Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcAgeBtn_Click(object sender, EventArgs e)
        {
            string vYOB = YOBTextBox.Text;
            int vYOBInt;
            bool vCheckIntType = int.TryParse(vYOB, out vYOBInt); // this checks if the variable can be parsed into an integer. If not, it show an error so that a valid integer will be entered. If it is an integer (the first vYOB in the brakets), it doe not show an error and it returns the value if vYOBInt. However, if it is not an integer, it shows an error and the type should be changed. 

            if (String.IsNullOrEmpty(vYOB))
            {
                MessageBox.Show("Please enter a YOB");
            }
            else if (vCheckIntType == false)
            {
                MessageBox.Show("Please enter a valid integer");
            }
            else if ( vYOBInt<1850 || vYOBInt>DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a year between 1850 and " + DateTime.Now.Year + ".");
            }
            else
            {
                ErrorLabel.Text = "Valid year entered";
                AnsLabel.Text = CalcAge(vYOBInt).ToString() + " years old."; // to display the answer in the label. vYOBInt is the value that will be passed. and the .ToString() method is becasue Labels only accept strings. 
            }
        }
        public int CalcAge(int vPassed)
        {
            return DateTime.Now.Year - vPassed; // calculate the age by subtracting the YOB from the current year
        }
    }
}
