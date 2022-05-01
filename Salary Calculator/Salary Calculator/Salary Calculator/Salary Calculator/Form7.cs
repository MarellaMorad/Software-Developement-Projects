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
    // Last edited: 07 - Aug - 2019


    public partial class Form7 : Form
    {
        //public variables so that they can be used througout the program
        string vPPH; // to store the pay per hour

        string vUsername;
        string vDate = DateTime.Now.ToString("dd-MM-yy"); // to store the date

        double StartTime; // to store the start time
        double FinishTime; // to store the finish time

        // all these variables are public as they will be used in multiple methods/procedures
        double vWorkTimeDay = 0; // to store the hours worked per day
        double vWorkTimeWeek = 0; // // to store the hours worked per week
        double vWorkTimeMonth = 0; // to store the hours worked per month

        double vPayDay; // to store the pay per day
        double vPayWeek; // to store the pay per week
        double vPayMonth; // to store the pay per month

        int i = 1; // to count the days
        int w; // to count weeks
        int m; // to count months

        string vDayNum; // To store the day number - so it can be further used to determine weeks, months...
        string vWeekNum;// to store the week number
        string vMonthNum; // to store the month number
        int vDayNumInt;

        bool StartFound = false; // to store whether the start time is found or not
        bool EndFound = false; // to store whether the finish time is found or not
        bool DateFound = false; // to store whether the date was found or not

        string vDisplayChoice; // to store the dispaly choice
        string vDateCheck; // to store the last date recoreded in the xml and check it with the current date
        int daysDiff;

        // two variables to be user in the DisplayInListBox() method/procedure
        double TimeDayDisplay; // to store the time per day for display purposes
        double PayDayDisplay; // to store the pay per day for display purposes

        // crearte an array and assign it 7 values becuase the display will be per week - only 7 days
        double[] ArrTimeDay = new double[7];
        double[] ArrPayDay = new double[7];

        public Form7()
        {
            if (String.IsNullOrEmpty(Form3.passingText))
            {
                vUsername = Form2.passingText;
            }
            else if (String.IsNullOrEmpty(Form2.passingText))
            {
                vUsername = Form3.passingText;
            }

            InitializeComponent();
            DateLabel.Text = vDate; // display date

            InstLabel.Visible = false; // hide the InstLabel as we haven't yet checked if the salary is calculated or not

            SaveNotWorkedDays(); // Runs first so that the program doesn't crush in case of a no working day

            if (vPPH == null)
            {
                PayAmountDisplay.Visible = false;
                PayDisplay.Visible = false;
                NoChangeBtn.Visible = false;
                ChangeBtn.Visible = false;
            }
            else if (vPPH != null)
            {
                HrsInstLabel.Visible = false;
                PayTextBox.Visible = false;
                CalcBtn.Visible = false;
                PayAmountDisplay.Visible = true;
                PayDisplay.Visible = true;
                NoChangeBtn.Visible = true;
                ChangeBtn.Visible = true;
                PayAmountDisplay.Text = "$" + vPPH;
            }

            vDate = DateTime.Now.ToString("dd-MM-yy"); // set the date back to current day
        }

        int count = 0;

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            // start with validating the pay entered in the textbox
            if (vPPH == null)
            {
                PayValidation(); // validate the values entered for the pay
            }
            else if (count == 1)
            {
                CalcBtn.Enabled = false;
                ExistanceCheck(); // as the pay is already recorded, run the existance check
            }
        }

        void PayValidation()
        {
            vPPH = PayTextBox.Text; // set the value to whatever the user enters

            // variables to assist in type check
            double vPPHDouble;
            bool CheckDoubleType = double.TryParse(vPPH, out vPPHDouble);
            bool PaySpaces = vPPH.Contains(" ");
            bool PayComma = vPPH.Contains(",");

            if (String.IsNullOrEmpty(vPPH)) // check if the textBox is empty - no values entered and display a message
            {
                MessageBox.Show("Please enter how much you get paid per hour");
            }

            else if (PaySpaces == true)
            {
                MessageBox.Show("Spaces aren’t accepted, please retype your PAY without any spaces");
            }

            else if (CheckDoubleType == false || PayComma == true) // check if the data entered is double - no symboles or letters allowed (except for ".") and display a message
            {
                MessageBox.Show("Please enter a numerical value, note that no charcters are allowed except for a dot (.)");
            }

            else if (vPPHDouble < 0) // check for negative values and display a message
            {
                MessageBox.Show("Please enter a valid Pay - no negative numbers!");
            }

            else
            {
                DialogResult dialog = MessageBox.Show("Is this your Pay per hour: " + vPPH, "Exit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    CalcBtn.Enabled = false; // disable the CalcBtn if the value passes the validation

                    //after checking all possible values/no values entered, an existance check will run to check if the xml file exists or not
                    ExistanceCheck();
                }
                else if (dialog == DialogResult.No)
                {
                    //Nothing
                }
            }
        }

        void ExistanceCheck()
        {
            if (File.Exists(vUsername + "start.xml") == true && File.Exists(vUsername + "end.xml") == true)
            {
                StartTimeExistanceValidation(); // Validation starts - checks if the start time has been reocrede for the day
            }
            else if (File.Exists(vUsername + "start.xml") == false || File.Exists(vUsername + "start.xml") == false)
            {
                MessageBox.Show("Opps, it seems like you have forgetten to enter a Start/Finish time");

                // if the xml files do not exist, send the user back to the selection page to enter their start/finish time
                Form4 Selection = new Form4(); // open the next form
                Selection.Show();
                this.Hide();
            }

        }

        void StartTimeExistanceValidation()
        {
            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(vUsername + "start.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "/user")) //to run through the xml file
            {
                //check if the current date exists in XML file
                if (xNode.SelectSingleNode("date").InnerText == vDate)
                {
                    StartFound = true;
                }
            }

            if (StartFound == true)
            {
                FinishTimeExistanceValidation(); // Run the finish time check if the start time was found
            }
            else // of not found!
            {
                MessageBox.Show("Oops, it seems like you have forgetten to enter a Start time");

                // if the start time is missing, send the user back to the start time form
                Form5 Start = new Form5();
                Start.Show();
                this.Hide();
            }
        }

        void FinishTimeExistanceValidation()
        {
            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(vUsername + "end.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "/user")) //to run through the xml file
            {
                //check if the current date exists in XML file
                if (xNode.SelectSingleNode("date").InnerText == vDate)
                {
                    EndFound = true;
                }
            }

            if (EndFound == true) // if both times are found, then get them from the xml files
            {
                // to get the times from the xml files
                GetStartTime();
                GetEndTime();

                // Run the XmlCheck method
                XmlCheck();
            }
            else // if not found!
            {
                MessageBox.Show("Oops, it seems like you have forgotten to enter a Finish time");

                // if the finish time doesn't exist, send the user to the finish form
                Form6 Finish = new Form6();
                Finish.Show();
                this.Hide();
            }
        }

        void GetStartTime() // to get the start time from the start xml and save for further calculations
        {
            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(vUsername + "start.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "/user")) //to run through the xml file
            {
                //check if the current date exists in XML file
                if (xNode.SelectSingleNode("date").InnerText == vDate)
                {
                    string start = xNode.SelectSingleNode("start").InnerText.ToString(); // get the starting time

                    start = start.Replace(":", "."); // to convert from time to double
                    StartTime = double.Parse(start);
                }
            }
        }

        void GetEndTime()
        {
            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(vUsername + "end.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "/user")) //to run through the xml file
            {
                //check if the date exists
                if (xNode.SelectSingleNode("date").InnerText == vDate)
                {
                    string end = xNode.SelectSingleNode("end").InnerText.ToString(); // get the finishing time

                    end = end.Replace(":", "."); // to convert from time to double
                    FinishTime = double.Parse(end);
                }
            }
        }

        void XmlCheck() // run a check to see whether or not the xml file exists and act upon the results
        {
            if (File.Exists(vUsername + "salary.xml") == false)
            {
                // calculate then store
                CalcFirstTime();
                NewXML(); // if it doesn't exist, create a new one
            }
            else if (File.Exists(vUsername + "salary.xml") == true)
            {
                // calculate then store
                CalcNextTime();
                DateExistance();
            }
        }

        void CalcFirstTime() // to calculate the pay/time for the first time - no addition of hours/pay required
        {
            vWorkTimeDay = Math.Round((FinishTime - StartTime), 2); // to calculate the time worked per day

            // if the start and finish time are in the same hour - no further calculations are needed - i.e. the highest is x.59
            // while if they were different i.e. 17.2 - 16.50 = 0.7 which will need -0.4 to get the actual time worked30 mins
            if (Math.Round(FinishTime, 0) == Math.Round(StartTime, 0))
            {
                vWorkTimeDay = vWorkTimeDay + 0;
            }
            else
            {
                vWorkTimeDay = Math.Round(vWorkTimeDay - 0.4, 2); // Round the answer to 2 decimal places
            }

            // to calculate the time worked per day
            var Mins = (double)(((decimal)vWorkTimeDay % 1) * 100); // to get the minutes only - the two numbers after the decimal point
            vWorkTimeDay = Math.Round(((vWorkTimeDay - (Mins / 100)) + (Mins / 60)), 2); // subtract mins from actual number and add mins/60 for accurate calculations

            vPayDay = Math.Round(vWorkTimeDay * double.Parse(vPPH), 2); // multiplying time by pay to get the salary per day

            // for the first time, these values equal to each other as only one day of the week has been worked
            vWorkTimeWeek = Math.Round(vWorkTimeDay, 2);
            vWorkTimeMonth = Math.Round(vWorkTimeWeek, 2);

            vPayWeek = Math.Round(vPayDay, 2);
            vPayMonth = Math.Round(vPayWeek, 2);

            vDayNum = i.ToString(); // to start the days counting
            vWeekNum = 1.ToString(); // to start the weeks counting
            vMonthNum = 1.ToString(); //to start the months counting
        }

        void CalcNextTime() // after the first calculation is done, addition of hours/pay are required
        {
            var vYesterday = DateTime.Now.AddDays(-1); // to get data from the previous day and add them to current day (for month and week calculations)

            vWorkTimeDay = Math.Round((FinishTime - StartTime), 2); // to calculate the time worked per day

            // if the start and finish time are in the same hour - no further calculations are needed - i.e. the highest is x.59
            // while if they were different i.e. 17.2 - 16.50 = 0.7 which will need -0.4 to get the actual time worked30 mins
            if (Math.Round(FinishTime, 0) == Math.Round(StartTime, 0))
            {
                vWorkTimeDay = vWorkTimeDay + 0;
            }
            else
            {
                vWorkTimeDay = Math.Round(vWorkTimeDay - 0.4, 2); // Round the answer to 2 decimal places
            }

            // to calculate the time worked per day
            var Mins = (double)(((decimal)vWorkTimeDay % 1) * 100); // to get the minutes only - the two numbers after the decimal point
            vWorkTimeDay = Math.Round(((vWorkTimeDay - (Mins / 100)) + (Mins / 60)), 2); // subtract mins from actual number and add mins/60 for accurate calculations

            vPayDay = Math.Round(vWorkTimeDay * double.Parse(vPPH), 2); // multiplying time by pay to get the salary per day

            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(vUsername + "salary.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "salary/user")) //to run through the xml file
            {
                //check if data from the previous day exists in the XML file
                if (xNode.SelectSingleNode("date").InnerText == vYesterday.ToString("dd-MM-yy"))
                {
                    // if so, get them and add them to today's earnings/hours
                    vWorkTimeWeek = Math.Round(vWorkTimeDay + (double.Parse(xNode.SelectSingleNode("timeWeek").InnerText)), 2);
                    vWorkTimeMonth = Math.Round(vPayDay + (double.Parse(xNode.SelectSingleNode("timeMonth").InnerText)), 2);

                    vPayWeek = Math.Round(vPayDay + (double.Parse(xNode.SelectSingleNode("payWeek").InnerText)), 2);
                    vPayMonth = Math.Round(vPayDay + (double.Parse(xNode.SelectSingleNode("payMonth").InnerText)), 2);

                    vDayNum = (int.Parse(xNode.SelectSingleNode("dayNum").InnerText) + 1).ToString(); // increment dayNum by 1
                    w = int.Parse(xNode.SelectSingleNode("weekNum").InnerText); // set the w counter to the week number saved in the xml
                    m = int.Parse(xNode.SelectSingleNode("monthNum").InnerText);// set the m counter to the month number saved in the xml

                    AssignWeekAndMonthNum(vDayNum); // Run this
                }
            }
        }

        void AssignWeekAndMonthNum(string vDayNumParsed) // to pass it the correct date value
        {
            vDayNumInt = int.Parse(vDayNumParsed); // turn the vDayNum into an integer and store it as vDayNumInt to be easier to refer to it

            if (vDayNumInt == (7 * w) + 1) // Check if a new week has statred
            {
                // if so, add 1 to the week number
                vWeekNum = (w + 1).ToString();

                //load the XML document
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(vUsername + "salary.xml");

                foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "salary/user")) //to run through the xml file
                {
                    int vWeekNumCheck = int.Parse(xNode.SelectSingleNode("weekNum").InnerText); //get the week number stored in the xml

                    if (vWeekNumCheck == w) // if it equals to w
                    {
                        // reset the week salary/time to only the salary/time for the day
                        vWorkTimeWeek = Math.Round(vWorkTimeDay, 2);
                        vPayWeek = Math.Round(vPayDay, 2);

                        //incease the day number
                        vDayNum = (int.Parse(xNode.SelectSingleNode("dayNum").InnerText) + 1).ToString();
                    }
                }
            }
            else if (vDayNumInt < (7 * w) + 1)
            {
                vWeekNum = w.ToString();
            }

            if (vDayNumInt == (30 * m) + 1)
            {
                vMonthNum = (m + 1).ToString(); // same as weeks, if a new month have started, you add 1 to the months number

                //load the XML document
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(vUsername + "salary.xml");

                foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "salary/user")) //to run through the xml file
                {
                    int vMonthNumCheck = int.Parse(xNode.SelectSingleNode("monthNum").InnerText);

                    if (vMonthNumCheck == m)
                    {
                        vWorkTimeMonth = Math.Round(vWorkTimeDay, 2);

                        vPayMonth = Math.Round(vPayDay, 2);

                        vDayNum = (int.Parse(xNode.SelectSingleNode("dayNum").InnerText) + 1).ToString();
                    }
                }
            }
            else if (vDayNumInt < (30 * m) + 1)
            {
                vMonthNum = m.ToString();
            }
        }

        void DateExistance()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(vUsername + "salary.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "salary/user")) //to run through the xml file
            {
                //check if the date already exists
                if (xNode.SelectSingleNode("date").InnerText == vDate)
                {
                    DateFound = true;
                }
            }

            if (DateFound == true)
            {
                MessageBox.Show("Oops, it looks like you have already calculated your pay for " + vDate);
            }
            else
            {
                SaveData();
            }
        }

        void NewXML()
        {
            //creates the XML file called dataBase.xml, using a new XmlTextWriter called xWriter
            XmlTextWriter xWriter = new XmlTextWriter(vUsername + "salary.xml", Encoding.UTF8);

            xWriter.Formatting = Formatting.Indented; // format the xml to use indentation
            xWriter.WriteStartElement(vUsername + "salary");
            xWriter.WriteStartElement("user");
            xWriter.WriteStartElement("date");
            xWriter.WriteString(vDate.ToString());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("pay_per_hour");
            xWriter.WriteString(vPPH);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("dayNum");
            xWriter.WriteString(vDayNum);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("weekNum");
            xWriter.WriteString(vWeekNum);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("monthNum");
            xWriter.WriteString(vMonthNum);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("timeDay");
            xWriter.WriteString(vWorkTimeDay.ToString());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("timeWeek");
            xWriter.WriteString(vWorkTimeWeek.ToString());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("timeMonth");
            xWriter.WriteString(vWorkTimeMonth.ToString());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("payDay");
            xWriter.WriteString(vPayDay.ToString());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("payWeek");
            xWriter.WriteString(vPayWeek.ToString());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("payMonth");
            xWriter.WriteString(vPayMonth.ToString());
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();

            xWriter.Close(); // to close access to the xml so it can be used by other applications.

            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(vUsername + "salary.xml");

            XmlDeclaration xmldecl; // create a declaration which is the line underneeth
            xmldecl = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

            //Insert the XML declaration into the XML file and save
            XmlElement root = xDoc.DocumentElement;
            xDoc.InsertBefore(xmldecl, root); // to insert it before the root element <user>
            xDoc.Save(vUsername + "salary.xml");
        }

        void SaveNotWorkedDays()  // in case the user did not work in a certain day of the week, zero data will be saved (in case the user doesn't work all days in the week)
        {
            if (File.Exists(vUsername + "salary.xml") == true)
            {
                // get the last node and call it last so we can check the not working days
                XPathNavigator last = new XPathDocument(vUsername + "salary.xml").CreateNavigator().SelectSingleNode("/*/*[last()]");

                // if last is not empty, then check how many days have not been reocrded
                if (last != null)
                {
                    vPPH = last.SelectSingleNode("pay_per_hour").InnerXml;
                    vDateCheck = last.SelectSingleNode("date").InnerXml; // get the date from last
                    DateTime date1 = DateTime.Parse(vDateCheck);
                    DateTime date2 = DateTime.Now;

                    daysDiff = ((TimeSpan)(date2 - date1)).Days; // subtract the two dates and get the difference

                    var vYesterday = DateTime.Now.AddDays(-1); // set vYesterday ti be used if only one day has not been recorded

                    if (daysDiff > 1) // if the days difference is more then one - as one represents correct recording - yesterday
                    {
                        if (daysDiff == 2) // which means only one day was not worked
                        {
                            vDate = vYesterday.ToString("dd-MM-yy"); // set the date to yesterday so the correct date will be saved
                            vDayNum = (int.Parse(last.SelectSingleNode("dayNum").InnerXml) + 1).ToString(); // increase the day number by 1
                            w = int.Parse(last.SelectSingleNode("weekNum").InnerXml);
                            m = int.Parse(last.SelectSingleNode("monthNum").InnerXml);

                            vPPH = last.SelectSingleNode("pay_per_hour").InnerXml;
                            vWorkTimeDay = 0; // worktimeday set to zero as it is a not worked day
                            //Same as vWorkTimeDay, no hours added, therefore, save as before
                            vWorkTimeWeek = double.Parse(last.SelectSingleNode("timeWeek").InnerXml);
                            vWorkTimeMonth = double.Parse(last.SelectSingleNode("timeMonth").InnerXml);

                            vPayDay = 0; // 0 not worked
                            // Same as the time/pay nothing added, saved as before
                            vPayWeek = double.Parse(last.SelectSingleNode("payWeek").InnerXml);
                            vPayMonth = double.Parse(last.SelectSingleNode("payMonth").InnerXml);

                            AssignWeekAndMonthNum(vDayNum); // check for the week and month number

                            SaveData(); // Not sure if to keep it here, or outside
                        }
                        else if (daysDiff > 2) // this means that more than one day has not been calcluated
                        {
                            for (int n = 0; n < daysDiff - 1; n++)
                            {
                                //Assign the values
                                vDate = (DateTime.Parse(vDateCheck).AddDays(1 + n)).ToString("dd-MM-yy");
                                vDayNum = (int.Parse(last.SelectSingleNode("dayNum").InnerXml) + 1 + n).ToString();
                                w = int.Parse(last.SelectSingleNode("weekNum").InnerXml);
                                m = int.Parse(last.SelectSingleNode("monthNum").InnerXml);

                                vPPH = last.SelectSingleNode("pay_per_hour").InnerXml;

                                vWorkTimeDay = 0;
                                vWorkTimeWeek = double.Parse(last.SelectSingleNode("timeWeek").InnerXml);
                                vWorkTimeMonth = double.Parse(last.SelectSingleNode("timeMonth").InnerXml);
                                vPayDay = 0;
                                vPayWeek = double.Parse(last.SelectSingleNode("payWeek").InnerXml);
                                vPayMonth = double.Parse(last.SelectSingleNode("payMonth").InnerXml);

                                AssignWeekAndMonthNum(vDayNum); // check for the week and month number

                                SaveData();
                            }
                        }
                    }

                    else if (daysDiff == 0) // this means the salary for the day has already been calculated
                    {
                        CalcBtn.Visible = false;
                        HrsInstLabel.Visible = false;
                        PayTextBox.Visible = false;
                        ChangeBtn.Visible = false;
                        PayAmountDisplay.Visible = false;
                        PayDisplay.Visible = false;

                        InstLabel.Visible = true;

                        vPPH = last.SelectSingleNode("pay_per_hour").InnerXml;
                        vDate = DateTime.Now.ToString("dd-MM-yy");
                        vDayNum = last.SelectSingleNode("dayNum").InnerXml;
                        w = int.Parse(last.SelectSingleNode("weekNum").InnerXml);
                        m = int.Parse(last.SelectSingleNode("monthNum").InnerXml);
                        AssignWeekAndMonthNum(vDayNum); // check for the week and month number
                        vWorkTimeDay = double.Parse(last.SelectSingleNode("timeDay").InnerXml);
                        vWorkTimeWeek = double.Parse(last.SelectSingleNode("timeWeek").InnerXml);
                        vWorkTimeMonth = double.Parse(last.SelectSingleNode("timeMonth").InnerXml);
                        vPayDay = double.Parse(last.SelectSingleNode("payDay").InnerXml);
                        vPayWeek = double.Parse(last.SelectSingleNode("payWeek").InnerXml);
                        vPayMonth = double.Parse(last.SelectSingleNode("payMonth").InnerXml);
                    }
                }
            }
        }

        void SaveData()
        {
            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(vUsername + "salary.xml");

            //create the new elements (under the root element)
            XmlNode user = xDoc.CreateElement("user"); //represents a single node/tag in the Xml file 
            XmlNode date = xDoc.CreateElement("date");
            XmlNode hourPay = xDoc.CreateElement("pay_per_hour");
            XmlNode dayNum = xDoc.CreateElement("dayNum");
            XmlNode weekNum = xDoc.CreateElement("weekNum");
            XmlNode monthNum = xDoc.CreateElement("monthNum");
            XmlNode timeDay = xDoc.CreateElement("timeDay");
            XmlNode timeWeek = xDoc.CreateElement("timeWeek");
            XmlNode timeMonth = xDoc.CreateElement("timeMonth");
            XmlNode payDay = xDoc.CreateElement("payDay");
            XmlNode payWeek = xDoc.CreateElement("payWeek");
            XmlNode payMonth = xDoc.CreateElement("payMonth");

            // To save the values calculated into the XML file
            date.InnerText = vDate.ToString();
            user.AppendChild(date);
            hourPay.InnerText = vPPH;
            user.AppendChild(hourPay);
            dayNum.InnerText = vDayNum;
            user.AppendChild(dayNum);
            weekNum.InnerText = vWeekNum;
            user.AppendChild(weekNum);
            monthNum.InnerText = vMonthNum;
            user.AppendChild(monthNum);
            timeDay.InnerText = vWorkTimeDay.ToString();
            user.AppendChild(timeDay);
            timeWeek.InnerText = vWorkTimeWeek.ToString();
            user.AppendChild(timeWeek);
            timeMonth.InnerText = vWorkTimeMonth.ToString();
            user.AppendChild(timeMonth);
            payDay.InnerText = vPayDay.ToString();
            user.AppendChild(payDay);
            payWeek.InnerText = vPayWeek.ToString();
            user.AppendChild(payWeek);
            payMonth.InnerText = vPayMonth.ToString();
            user.AppendChild(payMonth);
            xDoc.DocumentElement.AppendChild(user);
            xDoc.Save(vUsername + "salary.xml");
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            DisplayData(); //Run
        }

        void DisplayData()
        {
            if (DayRB.Checked == false && WeekRB.Checked == false && MonthRB.Checked == false) // if no radio button is checked
            {
                MessageBox.Show("Please select how you would like your salary to be displayed");
            }

            // assign vDisplayChoice, depending on the user's choice
            else if (DayRB.Checked == true)
            {
                vDisplayChoice = "Day";
            }
            else if (WeekRB.Checked == true)
            {
                vDisplayChoice = "Week";
            }
            else if (MonthRB.Checked == true)
            {
                vDisplayChoice = "Month";
            }

            // Load the xml document...
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(vUsername + "salary.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "salary/user")) //to run through the xml file
            {
                //check if the date exists in the xml file
                if (xNode.SelectSingleNode("date").InnerText == vDate)
                {
                    // if so, assign the variables to the most recent values in the xml file - to be displayed
                    vWorkTimeDay = double.Parse(xNode.SelectSingleNode("timeDay").InnerText);
                    vWorkTimeWeek = double.Parse(xNode.SelectSingleNode("timeWeek").InnerText);
                    vWorkTimeMonth = double.Parse(xNode.SelectSingleNode("timeMonth").InnerText);

                    vPayDay = double.Parse(xNode.SelectSingleNode("payDay").InnerText);
                    vPayWeek = double.Parse(xNode.SelectSingleNode("payWeek").InnerText);
                    vPayMonth = double.Parse(xNode.SelectSingleNode("payMonth").InnerText);
                }
            }

            //Display depending on the choice...
            if (vDisplayChoice == "Day")
            {
                PayLabel.Text = "You have worked " + vWorkTimeDay + " hour/s today and your salary is $" + vPayDay;
            }
            else if (vDisplayChoice == "Week")
            {
                PayLabel.Text = "You have worked " + vWorkTimeWeek + " hour/s this week and your salary is $" + vPayWeek;
            }
            else if (vDisplayChoice == "Month")
            {
                PayLabel.Text = "You have worked " + vWorkTimeMonth + " hour/s this month and your salary is $" + vPayMonth;
            }
        }

        private void DABtn_Click(object sender, EventArgs e)
        {
            DisplayInListBox(); //Run
            DABtn.Enabled = false; // Disable the displayanalysisbtn after displayed once
        }

        double value1 = 0;
        double value2 = 0;
        double value3 = 0;
        double value4 = 0;
        double value5 = 0;
        double value6 = 0;
        double value7 = 0;

        void DisplayInListBox()
        {
            // Load the xml
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(vUsername + "salary.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes(vUsername + "salary/user")) //to run through the xml file
            {
                if (int.Parse(xNode.SelectSingleNode("dayNum").InnerText) >= 7 * (int.Parse(vWeekNum) - 1) + 1 && int.Parse(xNode.SelectSingleNode("dayNum").InnerText) <= 7 * int.Parse(vWeekNum) + 1)
                {
                    TimeDayDisplay = double.Parse(xNode.SelectSingleNode("timeDay").InnerText); // get the time
                    PayDayDisplay = double.Parse(xNode.SelectSingleNode("payDay").InnerText); // get the pay

                    //store them in the arrays
                    ArrTimeDay[w] = TimeDayDisplay;
                    ArrPayDay[w] = PayDayDisplay;

                    // get and store the date
                    string vDisplayDate = xNode.SelectSingleNode("date").InnerText;

                    if (ArrTimeDay[w] > 0 && ArrPayDay[w] > 0) // if the user has worked in the day display it (didn't work = 0 time & 0 money)
                    {
                        WAListBox.Items.Add(vDisplayDate + ": " + "Working hours = " + ArrTimeDay[w] + ", and Salary = $" + ArrPayDay[w]);
                    }
                }
            }

            string[] lines = new string[WAListBox.Items.Count];

            for (int c = 0; c < WAListBox.Items.Count; c++)
            {
                lines[c] = WAListBox.GetItemText(WAListBox.Items[c]);
            }

            if (WAListBox.Items.Count == 1)
            {
                value1 = double.Parse(lines[0].Substring(lines[0].IndexOf('$') + 1));
            }
            else if (WAListBox.Items.Count == 2)
            {
                value1 = double.Parse(lines[0].Substring(lines[0].IndexOf('$') + 1));
                value2 = double.Parse(lines[1].Substring(lines[1].IndexOf('$') + 1));
            }
            else if (WAListBox.Items.Count == 3)
            {
                value1 = double.Parse(lines[0].Substring(lines[0].IndexOf('$') + 1));
                value2 = double.Parse(lines[1].Substring(lines[1].IndexOf('$') + 1));
                value3 = double.Parse(lines[2].Substring(lines[2].IndexOf('$') + 1));
            }
            else if (WAListBox.Items.Count == 4)
            {
                value1 = double.Parse(lines[0].Substring(lines[0].IndexOf('$') + 1));
                value2 = double.Parse(lines[1].Substring(lines[1].IndexOf('$') + 1));
                value3 = double.Parse(lines[2].Substring(lines[2].IndexOf('$') + 1));
                value4 = double.Parse(lines[3].Substring(lines[3].IndexOf('$') + 1));
            }
            else if (WAListBox.Items.Count == 5)
            {
                value1 = double.Parse(lines[0].Substring(lines[0].IndexOf('$') + 1));
                value2 = double.Parse(lines[1].Substring(lines[1].IndexOf('$') + 1));
                value3 = double.Parse(lines[2].Substring(lines[2].IndexOf('$') + 1));
                value4 = double.Parse(lines[3].Substring(lines[3].IndexOf('$') + 1));
                value5 = double.Parse(lines[4].Substring(lines[4].IndexOf('$') + 1));
            }
            else if (WAListBox.Items.Count == 6)
            {
                value1 = double.Parse(lines[0].Substring(lines[0].IndexOf('$') + 1));
                value2 = double.Parse(lines[1].Substring(lines[1].IndexOf('$') + 1));
                value3 = double.Parse(lines[2].Substring(lines[2].IndexOf('$') + 1));
                value4 = double.Parse(lines[3].Substring(lines[3].IndexOf('$') + 1));
                value5 = double.Parse(lines[4].Substring(lines[4].IndexOf('$') + 1));
                value6 = double.Parse(lines[5].Substring(lines[5].IndexOf('$') + 1));
            }
            else if (WAListBox.Items.Count == 7)
            {
                value1 = double.Parse(lines[0].Substring(lines[0].IndexOf('$') + 1));
                value2 = double.Parse(lines[1].Substring(lines[1].IndexOf('$') + 1));
                value3 = double.Parse(lines[2].Substring(lines[2].IndexOf('$') + 1));
                value4 = double.Parse(lines[3].Substring(lines[3].IndexOf('$') + 1));
                value5 = double.Parse(lines[4].Substring(lines[4].IndexOf('$') + 1));
                value6 = double.Parse(lines[5].Substring(lines[5].IndexOf('$') + 1));
                value7 = double.Parse(lines[6].Substring(lines[6].IndexOf('$') + 1));
            }

            double[] ArrPayForSorting = new double[7];

            ArrPayForSorting[0] = value1;
            ArrPayForSorting[1] = value2;
            ArrPayForSorting[2] = value3;
            ArrPayForSorting[3] = value4;
            ArrPayForSorting[4] = value5;
            ArrPayForSorting[5] = value6;
            ArrPayForSorting[6] = value7;

            SelectionSort(ArrPayForSorting);
            DisplaySelectionArray(ArrPayForSorting);
        }

        void SelectionSort(double[] array) // to sort pay from highest to lowest and then display it in the list box
        {
            int pos_min = 0; //stores the index of the currently found lowest number
            double temp = 0; // stores the value (not the index) to be swapped

            for (int i = 0; i <= array.Length - 1; i++)
            {
                pos_min = i;
                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    if (array[j] < array[pos_min]) //checks if the value in index j is less than the value in index pos_min 
                    {
                        pos_min = j; // sets pos_min to the smallest value
                    }
                }

                //swap
                if (pos_min != i)
                {
                    temp = array[i];
                    array[i] = array[pos_min];
                    array[pos_min] = temp;
                }
            }
        }

        void DisplaySelectionArray(double[] array)
        {
            // to display the sorted array in the Pay ranking listbox
            for (int j = 0; j <= array.Length - 1; j++)
            {
                if (array[j] > 0)
                {
                    PRListBox.Items.Add("$" + array[j]);
                }
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
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
            Form6 Finish = new Form6();
            Finish.Show();
            this.Hide();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            ChangeBtn.Visible = false;
            PayAmountDisplay.Visible = false;
            PayDisplay.Visible = false;
            HrsInstLabel.Visible = true;
            PayTextBox.Visible = true;
            NoChangeBtn.Visible = false;

            vPPH = null;
            CalcBtn.Visible = true;
        }

        private void NoChangeBtn_Click(object sender, EventArgs e)
        {
            count++;
            CalcBtn.Visible = true;
            ChangeBtn.Visible = false;
            NoChangeBtn.Visible = false;
        }
    }
}