using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Begin
             *  Get Username
             *  Get Passowrd
             *  
             *  If Username = "user" THEN
             *      If Password = "123" THEN
             *          Open form2
             *          Close form 1
             *      Else
             *          Display please enter the password
             *      EndIf
             *  Else
             *      Display please enter the username
             *  EndIf
             * End
             */

            string vUsername = textBox1.Text;
            string vPassword = textBox2.Text;

            if (vUsername == "user")
            {
                if (vPassword == "123")
                {
                    Form2 nextForm = new Form2(); //name the second form
                    this.Hide(); // hide Form1 from view only
                    nextForm.ShowDialog(); //Show Form2
                    this.Close(); //Closes the whole program
                }
                else
                {
                    MessageBox.Show("Please enter the password");
                }
            }
            else
            {
                MessageBox.Show("Please enter the username");
            }
        }
    }
}
