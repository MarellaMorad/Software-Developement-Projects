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
using System.Xml.XPath; // to be able to track the last node in the xml file

namespace Marella_MORAD___SD_SAT___2019
{
    // By: Marella MORAD
    // Last edited: 23 - Jul - 2019

    public partial class Form5 : Form
    {
        //public variables to be used all over the program
        string vUsername;
        string vDate = DateTime.Now.ToString("dd-MM-yy"); // to get the current date

        bool Manual = false; // public as it will be used in more than one method

        bool Found = false; // to check whether the date already exists

        public Form5()
        {
            InitializeComponent();
            DateLabel.Text = vDate; // display date
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // assign the username depeing the on the user's login/signup
            if (String.IsNullOrEmpty(Form3.passingText))
            {
                vUsername = Form2.passingText;
            }
            else if (String.IsNullOrEmpty(Form2.passingText))
            {
                vUsername = Form3.passingText;
            }

            if (ManRB.Checked == false && AutoRB.Checked == false)
            {
                MessageBox.Show("Please select either you want the time to be recorded AUTOMATICALLY or MANUALLY"); // Show a message if neither of the radio buttons was checked
            }

            DateExistance();
        }

        void RecordSelection()
        {
            if (AutoRB.Checked == true)
            {
                Manual = false; // set manual to false if the AutoRB is checked
                TimeConfirmation(DateTime.Now.ToString("HH:mm"));
            }
            else if (ManRB.Checked == true)
            {
                Manual = true; // set manual to true if the ManRB is checked
                TimeConfirmation(ManTimePicker.Text);
            }
        }

        // double check the time with the user
        void TimeConfirmation(string time)
        {
            DialogResult dialog = MessageBox.Show("Is this your Start time: " + time, "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                XmlCheck(); // to run the XmlCheck if one of the radio buttons is checked correctly 
            }
            else if (dialog == DialogResult.No)
            {
                //Nothing
            }
        }

        void XmlCheck()
        {
            if (File.Exists(vUsername + "start.xml") == false)
            {
                NewXML(); // if the file doesn't exist, create a new one
            }
            else if (File.Exists(vUsername + "start.xml") == true)
            {
                SaveData(); // if the date passes the validation, then SaveData
            }
        }

        void NewXML()
        {
            if (Manual == true)
            {
                //creates the XML file that will be named after the person who logged in, using a new XmlTextWriter called xWriter
                XmlTextWriter xWriter = new XmlTextWriter(vUsername + "start.xml", Encoding.UTF8);

                xWriter.Formatting = Formatting.Indented; // format the xml to use indentation
                xWriter.WriteStartElement(vUsername);
                xWriter.WriteStartElement("user");
                xWriter.WriteStartElement("date");
                xWriter.WriteString(vDate);
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("start");
                xWriter.WriteString(ManTimePicker.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();

                xWriter.Close(); // to close access to the xml so it can be used by other applications.

                XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
                xDoc.Load(vUsername + "start.xml");

                XmlDeclaration xmldecl; // create a declaration which is the line underneeth
                xmldecl = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

                //Insert the XML declaration into the XML file and save
                XmlElement root = xDoc.DocumentElement;
                xDoc.InsertBefore(xmldecl, root); // to insert it before the root element <library>
                xDoc.Save(vUsername + "start.xml");
            }

            else if (Manual == false)
            {
                //creates the XML file that will be named after the person who logged in, using a new XmlTextWriter called xWriter
                XmlTextWriter xWriter = new XmlTextWriter(vUsername + "start.xml", Encoding.UTF8);

                xWriter.Formatting = Formatting.Indented; // format the xml to use indentation
                xWriter.WriteStartElement(vUsername);
                xWriter.WriteStartElement("user");
                xWriter.WriteStartElement("date");
                xWriter.WriteString(vDate);
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("start");
                xWriter.WriteString(DateTime.Now.ToString("HH:mm"));
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();

                xWriter.Close(); // to close access to the xml so it can be used by other applications.

                XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
                xDoc.Load(vUsername + "start.xml");

                XmlDeclaration xmldecl; // create a declaration which is the line underneeth
                xmldecl = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

                //Insert the XML declaration into the XML file and save
                XmlElement root = xDoc.DocumentElement;
                xDoc.InsertBefore(xmldecl, root); // to insert it before the root element <library>
                xDoc.Save(vUsername + "start.xml");
            }
        }

        void DateExistance()
        {
            if (File.Exists(vUsername + "start.xml") == true)
            {
                XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
                xDoc.Load(vUsername + "start.xml");

                foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "/user")) //to run through the xml file
                {
                    //check if the username is already taken
                    if (xNode.SelectSingleNode("date").InnerText == vDate)
                    {
                        Found = true;
                    }
                }
            }

            if (Found == true)
            {
                MessageBox.Show("Oops, it looks like you have already entered a START time for the day");
            }
            else if (Found == false)
            {
                RecordSelection();
            }
        }

        void SaveData()
        {
            if (Manual == true)
            {
                //load the XML document
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(vUsername + "start.xml");

                //create the new elements (under the root element)
                XmlNode user = xDoc.CreateElement("user"); //represents a single node/tag in the Xml file 
                XmlNode date = xDoc.CreateElement("date");
                XmlNode start = xDoc.CreateElement("start");

                // Get the value from the textbox and put into the text of the element, save the XML
                date.InnerText = vDate;
                user.AppendChild(date);
                start.InnerText = ManTimePicker.Text;
                user.AppendChild(start);
                xDoc.DocumentElement.AppendChild(user);
                xDoc.Save(vUsername + "start.xml"); // Save everything
            }

            else if (Manual == false)
            {
                //load the XML document
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(vUsername + "start.xml");

                //create the new elements (under the root element)
                XmlNode user = xDoc.CreateElement("user"); //represents a single node/tag in the Xml file 
                XmlNode date = xDoc.CreateElement("date");
                XmlNode start = xDoc.CreateElement("start");

                // Get the value from the textbox and put into the text of the element, save the XML
                date.InnerText = vDate;
                user.AppendChild(date);
                start.InnerText = DateTime.Now.ToString("HH:mm");
                user.AppendChild(start);
                xDoc.DocumentElement.AppendChild(user);
                xDoc.Save(vUsername + "start.xml"); // Save everything
            }
        }

        protected override void OnPaint(PaintEventArgs e) //to draw a line seperating the auto and manual entering methods
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(Pens.Black, 175, 140, 175, 300);
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread(); // to exit the program if the user press on the x button
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true; // to not exit the program if the user pressed No (as exit may be pressed by mistake and therefore avoid loss of data)
            }
        }

        private void SkipBackBtn_Click(object sender, EventArgs e)
        {
            Form4 Selection = new Form4(); // open the next form
            Selection.Show();
            this.Hide();
        }

        private void SkipBtn_Click(object sender, EventArgs e)
        {
            Form6 Finish = new Form6();
            Finish.Show(); // open the Finish form
            this.Hide(); // Close this one
        }
    }
}