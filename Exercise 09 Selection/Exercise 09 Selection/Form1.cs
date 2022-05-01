using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_09_Selection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {

            string vScore = ScoreTextBox.Text;

            int vScoreInt;

            bool vCheckIntType = int.TryParse(vScore, out vScoreInt);

            if (String.IsNullOrEmpty(vScore))
            {
                MessageBox.Show("Please enter a score");
            }
            else if (vScore == "NS")
            { 
                GradeLabel.Text = "NS";
                CommentLabel.Text = "NOT Satisfactory";
            }

            else if (vScore == "NP")
            {
                GradeLabel.Text = "NP";
                CommentLabel.Text = "NOT Present";
            }

            else if (vCheckIntType == false)
            {
                MessageBox.Show("Please enter a numric value");
            }

            else if (vScoreInt < 0 || vScoreInt > 100)
            {
                MessageBox.Show("Please enter a value between 0 and 100");
            }

            else
            {
                GradeLabel.Text = vScoreInt.ToString();
            }

            if (vScore == "NS")
            {
                GradeLabel.Text = "NS";
                CommentLabel.Text = "NOT Satisfactory";
            }
            else if (vScore == "NP")
            {
                GradeLabel.Text = "NP";
                CommentLabel.Text = "NOT Present";
            }

            else if (vScoreInt >= 80 && vScoreInt <= 100)
            {
                GradeLabel.Text = "A";
                CommentLabel.Text = "Excellent";
            }
            else if (vScoreInt >= 70 && vScoreInt <= 79)
            {
                GradeLabel.Text = "B";
                CommentLabel.Text = "Very Good";
            }
            else if (vScoreInt >= 60 && vScoreInt <= 69)
            {
                GradeLabel.Text = "C";
                CommentLabel.Text = "Good";
            }
            else if (vScoreInt >= 50 && vScoreInt <= 59)
            {
                GradeLabel.Text = "D";
                CommentLabel.Text = "Satisfactory";
            }
            else if (vScoreInt >= 40 && vScoreInt <= 49)
            {
                GradeLabel.Text = "E";
                CommentLabel.Text = "Satisfactory";
            }
            else
            {
                GradeLabel.Text = "PASS";
                CommentLabel.Text = "Reasonable effort, required work completed and/or submitted, showing some understanding";
            }

        }
    }
}
