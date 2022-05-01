using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_10_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            string vPC = PCTextBox.Text;
            int vPCInt;

            bool vCheckIntType = int.TryParse(vPC, out vPCInt);

            if (String.IsNullOrEmpty(vPC))
            {
                MessageBox.Show("Please enter a postcode");
            }
            else if (vCheckIntType == false)
            {
                MessageBox.Show("Please enter an integer");
            }
            else if (3000 >= vPCInt && vPCInt >= 3999)
            {
                MessageBox.Show("Please enter a value between 3000-3999 or between 8000-8999");
            }
            else if (8000 >= vPCInt && vPCInt >= 8999)
            {
                MessageBox.Show("Please enter a value between 3000-3999 or between 8000-8999");
            }
            else
            {
                CheckLabel.Text = "Valid PostCode";
            }
        }
    }
}
