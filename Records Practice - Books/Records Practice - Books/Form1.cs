using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Records_Practice___Books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Books book1;
            book1.Name = "Software Development: Core Techniques And Principles 3rd Edition";
            book1.Author = "Adrian Janson";
            book1.ISBN = "978 - 0 - 9750764 - 6 - 0";
            book1.Publisher = "Adrian Janson Publishing";
            book1.YearOfRelease = 2015;

            DisplayLabel.Text = book1.Author;
        }

        struct Books
        {
            public string Name;
            public string Author;
            public string ISBN;
            public string Publisher;
            public int YearOfRelease;
        }

    }
}
