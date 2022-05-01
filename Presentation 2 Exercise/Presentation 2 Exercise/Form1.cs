using System;
using System.Windows.Forms;

namespace Presentation_2_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeLabelButton_Click(object sender, EventArgs e)
        {
            ExampleLabel.Text = ExampleTextBox.Text;
        }

        private void ShowPicButton_Click(object sender, EventArgs e)
        {
            ExamplePictureBox.Visible = true;
        }

        private void HidePicButton_Click(object sender, EventArgs e)
        {
            ExamplePictureBox.Visible = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ExampleLabel.Text = "This is an example label";
            ExampleTextBox.Clear();
            ExamplePictureBox.Visible = false;
        }
    }
}
