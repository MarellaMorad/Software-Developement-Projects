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
    // Last edited: 24 - Jul - 2019

    public partial class Form6 : Form
    {
        //public variables to be used all over the program
        string vUsername;
        string vDate = DateTime.Now.ToString("dd-MM-yy"); // to get the current date
        string vEndTime;

        bool Manual = false; // public as it will be used in more than one method

        bool Found = false;
        bool StartNotExist = false;

        public Form6()
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
            DialogResult dialog = MessageBox.Show("Is this your Finish time: " + time, "Exit", MessageBoxButtons.YesNo);
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
            if (File.Exists(vUsername + "end.xml") == false)
            {
                NewXML();
            }
            else if (File.Exists(vUsername + "end.xml") == true)
            {
                SaveData();
            }
        }

        void DateExistance()
        {
            if (File.Exists(vUsername + "end.xml") == true)
            {
                XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
                xDoc.Load(vUsername + "end.xml");

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
                MessageBox.Show("Oops, it looks like you have already entered a FINISH time for the day");
            }
            else
            {
                TimeValidation();
            }
        }

        void TimeValidation()
        {
            if (File.Exists(vUsername + "start.xml") == true)
            {
                XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
                xDoc.Load(vUsername + "start.xml");

                foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "/user")) //to run through the xml file
                {
                    if (xNode.SelectSingleNode("date").InnerText == vDate) // check for a specific date
                    {
                        StartNotExist = false;
                        string vStartTime = xNode.SelectSingleNode("start").InnerText.ToString(); // get the start time
                        vStartTime = vStartTime.Replace(":", "");
                        int StartTimeInt = int.Parse(vStartTime); // turn it into an integer and save it as StartTimeInt

                        // Get the end time, turn it into an int and save it as EndTimeInt
                        vEndTime = ManTimePicker.Text;
                        vEndTime = vEndTime.Replace(":", "");
                        int EndTimeInt = int.Parse(vEndTime);

                        // Check if the end time is less than or equal to start time
                        // Only for the manual as the auto one will always be later than the previous one
                        if (EndTimeInt <= StartTimeInt)
                        {
                            MessageBox.Show("The time you chose, is same as or earlier than your start time, please pick a different time");
                        }
                        else if (EndTimeInt > StartTimeInt) // if the end time is later than the start
                        {
                            if (File.Exists(vUsername + "end.xml") == false)
                            {
                                RecordSelection();
                            }
                            else if (File.Exists(vUsername + "end.xml") == true)
                            {
                                RecordSelection();
                            }
                        }
                    }
                    else if (xNode.SelectSingleNode("date").InnerText != vDate)
                    {
                        StartNotExist = true;
                    }
                }

                if (StartNotExist == true)
                {
                    DialogResult dialog = MessageBox.Show("Oops, it looks like you have NOT entered a START time for the day, would you like to enter it now?", "Exit", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        Form5 Start = new Form5();
                        Start.Show();
                        this.Hide();
                    }
                    else if (dialog == DialogResult.No)
                    {
                        //Nothing
                    }
                }                    
            }

            else if (File.Exists(vUsername + "start.xml") == false)
            {
                DialogResult dialog = MessageBox.Show("Oops, it looks like you have NOT entered a START time for the day, would you like to enter it now?", "Exit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Form5 Start = new Form5();
                    Start.Show();
                    this.Hide();
                }
                else if (dialog == DialogResult.No)
                {
                    //Nothing
                }
            }

        }

        void NewXML()
        {
            if (Manual == true)
            {

                //creates the XML file that will be named after the person who logged in, using a new XmlTextWriter called xWriter
                XmlTextWriter xWriter = new XmlTextWriter(vUsername + "end.xml", Encoding.UTF8);

                xWriter.Formatting = Formatting.Indented; // format the xml to use indentation
                xWriter.WriteStartElement(vUsername);
                xWriter.WriteStartElement("user");
                xWriter.WriteStartElement("date");
                xWriter.WriteString(vDate);
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("end");
                xWriter.WriteString(ManTimePicker.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();

                xWriter.Close(); // to close access to the xml so it can be used by other applications.

                XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
                xDoc.Load(vUsername + "end.xml");

                XmlDeclaration xmldecl; // create a declaration which is the line underneeth
                xmldecl = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

                //Insert the XML declaration into the XML file and save
                XmlElement root = xDoc.DocumentElement;
                xDoc.InsertBefore(xmldecl, root); // to insert it before the root element <library>
                xDoc.Save(vUsername + "end.xml");
            }

            else if (Manual == false)
            {
                //creates the XML file that will be named after the person who logged in, using a new XmlTextWriter called xWriter
                XmlTextWriter xWriter = new XmlTextWriter(vUsername + "end.xml", Encoding.UTF8);

                xWriter.Formatting = Formatting.Indented; // format the xml to use indentation
                xWriter.WriteStartElement(vUsername);
                xWriter.WriteStartElement("user");
                xWriter.WriteStartElement("date");
                xWriter.WriteString(vDate);
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("end");
                xWriter.WriteString(DateTime.Now.ToString("HH:mm"));
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();

                xWriter.Close(); // to close access to the xml so it can be used by other applications.

                XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
                xDoc.Load(vUsername + "end.xml");

                XmlDeclaration xmldecl; // create a declaration which is the line underneeth
                xmldecl = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

                //Insert the XML declaration into the XML file and save
                XmlElement root = xDoc.DocumentElement;
                xDoc.InsertBefore(xmldecl, root); // to insert it before the root element <library>
                xDoc.Save(vUsername + "end.xml");
            }

            MessageBox.Show("Data Saved, please make sure you calculate your pay before 11:59 pm, as after this time you will not be able to calculate the pay - it becomes a previous day");
        }

        void SaveData()
        {
            if (Manual == true)
            {
                //load the XML document
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(vUsername + "end.xml");

                //create the new elements (under the root element)
                XmlNode user = xDoc.CreateElement("user"); //represents a single node/tag in the Xml file 
                XmlNode date = xDoc.CreateElement("date");
                XmlNode end = xDoc.CreateElement("end");

                // Get the value from the textbox and put into the text of the element, save the XML
                date.InnerText = vDate;
                user.AppendChild(date);
                end.InnerText = ManTimePicker.Text;
                user.AppendChild(end);
                xDoc.DocumentElement.AppendChild(user);
                xDoc.Save(vUsername + "end.xml"); // Save everything
            }
            else if (Manual == false)
            {
                //load the XML document
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(vUsername + "end.xml");

                //create the new elements (under the root element)
                XmlNode user = xDoc.CreateElement("user"); //represents a single node/tag in the Xml file 
                XmlNode date = xDoc.CreateElement("date");
                XmlNode end = xDoc.CreateElement("end");

                // Get the value from the textbox and put into the text of the element, save the XML
                date.InnerText = vDate;
                user.AppendChild(date);
                end.InnerText = DateTime.Now.ToString("HH:mm");
                user.AppendChild(end);
                xDoc.DocumentElement.AppendChild(user);
                xDoc.Save(vUsername + "end.xml"); // Save everything
            }

            MessageBox.Show("Data Saved, please make sure you calculate your pay before 11:59 pm, as after this time you will not be able to calculate the pay - it becomes a previous day");
        }

        protected override void OnPaint(PaintEventArgs e) //to draw a line seperating the auto and manual entering methods
        {
            base.OnPaint(e);

            e.Graphics.DrawLine(Pens.Black, 175, 140, 175, 300);
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
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
            Form5 Start = new Form5();
            Start.Show();
            this.Hide();
        }

        private void SkipBtn_Click(object sender, EventArgs e)
        {
            Form7 Calculator = new Form7();
            Calculator.Show(); // Open claculator
            this.Hide(); // Close this
        }
    }
}
