using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Input_Box_Array_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] Scores = new int[5];
            int Sum = 0;

            for (int i = 0; i < Scores.Length; i++)
            {
                Scores[i] = int.Parse(Interaction.InputBox("Entre Scores", "Scores"));
                Sum = Sum + Scores[i];
            }

            ScoresLabel.Text = Sum.ToString();
        }
    }
}
