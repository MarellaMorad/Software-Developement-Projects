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

namespace Exercise_2___Arrays_and_record
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int M = int.Parse(Interaction.InputBox("Please enter the number of students you have", "No. Of Stundents"));
            int[] Height = new int[M];

            int Average = 0;

            for (int i = 0; i < Height.Length; i++)
            {
                Height[i] = int.Parse(Interaction.InputBox("Please enter Heights", "Students' Heights"));
                Average = (Average + Height[i]);

                if (Height[i] > 170)
                {
                    int GreaterThan170 = 0;
                    GreaterThan170++;
                    Above170.Text = GreaterThan170.ToString();

                }
            }

            AverageLabel.Text = (Average / M).ToString();
            

        }
    }
}
