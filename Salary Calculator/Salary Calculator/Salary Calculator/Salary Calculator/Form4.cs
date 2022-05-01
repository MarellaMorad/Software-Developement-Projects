using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // to be able to use XML
using System.IO;

namespace Marella_MORAD___SD_SAT___2019
{
    // By: Marella MORAD
    // Last edited: 23 - Jul - 2019

    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //if StartBtn is clicked then open the Start page
        private void StartBtn_Click(object sender, EventArgs e)
        {
            Form5 Start = new Form5();
            Start.Show();
            this.Hide();
        }

        //If FinishBtn is clicked then open the finish page
        private void FinishBtn_Click(object sender, EventArgs e)
        {
            Form6 Finish = new Form6();
            Finish.Show();
            this.Hide();
        }

        //If CalcBtn is clicked then open the salary page
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Form7 Calculator = new Form7();
            Calculator.Show();
            this.Hide();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread(); // to exit the program if the user press on the x button
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to mmCalc, the calculator for your salary. " + Environment.NewLine + Environment.NewLine +
                "This calculator will allow you to SAVE your Start and Finish time, asks you for how much you get Paid Per Hour and then Calculates your Salary. It will also allow you to DISPLAY your Pay in 3 different formats - Day, Week and Month - depending on your choice" + Environment.NewLine + Environment.NewLine +
                "In this window you either choose entering your Start time, Finish time or just Calculate the salary if you have already entered both the Start and Finish times." + Environment.NewLine + Environment.NewLine +
                "Unfortunatly, you will not be able to enter the time for a previous day, only the current day." + Environment.NewLine + Environment.NewLine +
                "Also, if the time passes 11:59pm, you will not be able to calculate your pay, so please immediately calculate after you record your Finish time" + Environment.NewLine + Environment.NewLine +
                "In case of display, you will be able to display the current day along with any worked days from the week. You will also get a sum of the days/weeks' salaries" + Environment.NewLine + Environment.NewLine +
                "Wait for us in the next update, we'll have everyting done for you :)");
        }
    }
}