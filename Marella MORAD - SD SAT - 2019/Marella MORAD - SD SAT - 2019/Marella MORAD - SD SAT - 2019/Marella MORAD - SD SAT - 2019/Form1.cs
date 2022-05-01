using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Marella_MORAD___SD_SAT___2019
{
    // By: Marella MORAD
    // Last edited: 23 - Jul - 2019

    public partial class Membership : Form
    {
        public Membership()
        {
            InitializeComponent();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            Form2 SignUp = new Form2();
            SignUp.Show(); // Open SignUp
            this.Hide(); // Close this one
        }

        private void ExistBtn_Click(object sender, EventArgs e)
        {
            Form3 Login = new Form3();
            Login.Show(); // Open Login
            this.Hide(); // Close this one
        }

        private void Membership_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread(); // to exit the program if the user press on the X button
        }
    }
}