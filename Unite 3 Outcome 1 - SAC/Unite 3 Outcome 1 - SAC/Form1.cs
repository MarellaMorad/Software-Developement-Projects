using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // add the namespace Xml to use XML related classes
using System.IO; // add the IO namespace IO to use classes related to checking and loading files 

namespace Unite_3_Outcome_1___SAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            WDataValidation();
        }

        void WDataValidation() // create the weight validation method
        {
            string WeightV = WeightTextBox.Text; // set the WeightV variable to the text entered in the WeightTextBox
            double WeightValidDouble; // create a boolean variable to check for the data type

            bool vCheckDoubleType = double.TryParse(WeightV, out WeightValidDouble);

            if (String.IsNullOrEmpty(WeightV)) // condition if the text box is empty and display a message
            {
                MessageBox.Show("Please enter a Weight value");
            }

            else if (vCheckDoubleType == false) // check for the correct data type - double (no letters or symbols allowed - other than "." ) and display a message
            {
                MessageBox.Show("Please enter a numerical Weight value");
            }

            else if (WeightValidDouble < 0) // check for the range - no negative weight and display a message
            {
                MessageBox.Show("Please enter a valid Weight - no negative numbers!");
            }
            
            else
            {
                HDataValidation(); // run the height validation method IF the weight value passes all the tests
            }
        }

        void HDataValidation() // create the height validation method
        {
            string HeightV = HeightTextBox.Text; // set the HeightV variable to the text entered in the HeightTextBox
            double HeightValidDouble; // create a boolean variable to check for the data type

            bool vCheckDoubleType = double.TryParse(HeightV, out HeightValidDouble);

            if (String.IsNullOrEmpty(HeightV)) // condition if the text box is empty and display a message
            {
                MessageBox.Show("Please enter a Height value");
            }

            else if (vCheckDoubleType == false) // check for the correct data type - double (no letters or symbols allowed - other than "." ) and display a message
            {
                MessageBox.Show("Please enter a numerical Height value");
            }

            else if (HeightValidDouble < 0)  // check for the range - no negative height and display a message
            {
                MessageBox.Show("Please enter a valid Height - no negative numbers!");
            }

            else
            {
                BMICalc(); // Run the BMICalc method
                BMICat(); // Run the BMICat method
                XmlCheck(); // Run the XmlCheck method
                BMIData(); // Run the BMIData method
            }
        }


        void BMICalc() // create BMICalc method - to calcuate the BMI value for each height and weight
        {
            double vWeight = double.Parse(WeightTextBox.Text); //create a variable called vWeight to store the weight in kg
            double vHeight = double.Parse(HeightTextBox.Text); //create a variable called vHeight to store the height in m

            double vBMI = vWeight / (Math.Pow(vHeight, 2)); // create a variable called vBMI to store the BMI calculated values

            BMILabel.Text = Math.Round(vBMI, 1).ToString(); // gives the BMI value to one decimal place
        }

        void BMICat() // create BMICat method - will set each BMI value to a specific category
        {
            double vBMI = double.Parse(BMILabel.Text); // get the BMI value from the BMI label
            string vCategory; // create a variable called vCategory to store the categories assosiated with each value depending on the range the value is in

            if (vBMI < 18.5) // check if vBMI is less than 18.5
            {
                vCategory = "Underweight"; // set vCategory to Underweight
                CatLabel.ForeColor = System.Drawing.Color.Blue; // change the font color to blue

            }
            else if (vBMI <= 24.9) // check if vBMI is less than or equal to 24.9
            {
                vCategory = "Healthy Weight"; // set vCategory to Healthy Weight
                CatLabel.ForeColor = System.Drawing.Color.Green; // change the font color to green
            }
            else if (vBMI <= 29.9) // check if vBMI is less than or equal to 29.9
            {
                vCategory = "Overweight"; // set vCategory to Overweight
                CatLabel.ForeColor = System.Drawing.Color.Orange; // change the font color to orange
            }
            else // check if vBMI is any other possible value - greater than 29.9
            {
                vCategory = "Obese"; // set vCategory to Obese
                CatLabel.ForeColor = System.Drawing.Color.Red; // change the font color to Red
            }

            CatLabel.Text = vCategory; // display the category
        }

        void XmlCheck() // creat the XmlCheck method
        {
            if (File.Exists("measures.xml") == false) // check if the measures file does not exist
            {
                NewXML(); // run the NewXML method to create a new XML file
            }

            else if (File.Exists("measures.xml") == true) // check if the measures file exists
            {
                SaveData(); // run the SaveData method
            }
        }

        void NewXML() // create the NewXML method that will create a new XML file in case there isn't one already created
        {
            //creates the XML file called measures.xml, using a new XmlTextWriter called xWriter
            XmlTextWriter xWriter = new XmlTextWriter("measures.xml", Encoding.UTF8);

            xWriter.Formatting = Formatting.Indented; // format the xml to use indentation
            xWriter.WriteStartElement("measures"); // create the xml structure
            xWriter.WriteStartElement("person");
            xWriter.WriteStartElement("date"); // open element
            xWriter.WriteString(DateTime.Now.ToString("dd/MM/yyyy"));
            xWriter.WriteEndElement(); // close element
            xWriter.WriteStartElement("height");
            xWriter.WriteString(HeightTextBox.Text);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("weight");
            xWriter.WriteString(WeightTextBox.Text);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("BMI");
            xWriter.WriteString(BMILabel.Text);
            xWriter.WriteEndElement();

            xWriter.Close(); // to close access to the xml so it can be used by other applications.

            XmlDocument xDoc = new XmlDocument();// Load the xml file
            xDoc.Load("measures.xml");

            XmlDeclaration xmldecl; // create a declaration which is the line underneeth
            xmldecl = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

            //Insert the XML declaration into the XML file and save
            XmlElement root = xDoc.DocumentElement;
            xDoc.InsertBefore(xmldecl, root); // to insert it before the root element <measures>
            xDoc.Save("measures.xml"); // save the XML file

        }

        void SaveData()
        {
            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("measures.xml");

            //create the new elements (under the root element)
            XmlNode person = xDoc.CreateElement("person"); //represents a single node/tag in the Xml file 
            XmlNode date = xDoc.CreateElement("date");
            XmlNode height = xDoc.CreateElement("height");
            XmlNode weight = xDoc.CreateElement("weight");
            XmlNode BMI = xDoc.CreateElement("BMI");

            // Get the value from the textbox and put into the text of the element, save the XML
            date.InnerText = DateTime.Now.ToString("dd/MM/yyyy"); // get the current date and set it to date node in the XML
            person.AppendChild(date);
            height.InnerText = HeightTextBox.Text;
            person.AppendChild(height);
            weight.InnerText = WeightTextBox.Text;
            person.AppendChild(weight);
            BMI.InnerText = BMILabel.Text;
            person.AppendChild(BMI);
            xDoc.DocumentElement.AppendChild(person);
            xDoc.Save("measures.xml"); // save the XML

        }

        void BMIData()
        {
            //create arrays to store XML data, and variables
            double[] arrBMIAverage = new double[100]; // create an array to store the BMI values and set the number of values to a max of 100 values
            double vTotal = 0; // to store the total sum of the values so we can caluclate the average
            int vCount = 0; // counts the number of values that we will divide by
            double vAverage = 0; // store the averages - set to 0 to start with
            int i = 0;
            double vMin = 10000; // stores the minimum value
            double vMax = 0; // stores the maxinmum value

            //load XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("measures.xml");

            //Loop through each node/tag, select data from element into array, Increase i
            foreach (XmlNode xNode in xDoc.SelectNodes("measures/person"))
            {
                arrBMIAverage[i] = double.Parse(xNode.SelectSingleNode("BMI").InnerText);
                i++;
            }

            //loop to calculate the averages
            for (int j = 0; j <= arrBMIAverage.Length - 1; j++)
            {
                if (arrBMIAverage[j] > 0)
                {
                    vTotal = vTotal + arrBMIAverage[j];
                    vCount++;
                }
            }

            vAverage = vTotal / vCount; // calculate the average
            BMIAveLabel.Text = Math.Round(vAverage, 1).ToString(); // display the result to one decimal place

            //loop to find the Max value
            for (int j = 0; j <= arrBMIAverage.Length - 1; j++)
            {
                if (arrBMIAverage[j] > 0)
                {
                    if (arrBMIAverage[j] > vMax)
                    {
                        vMax = arrBMIAverage[j];
                    }
                }
            }

            BMIMaxLabel.Text = Math.Round(vMax, 1).ToString(); // display the result to one decimal place

            //loop to find the Min value
            for (int j = 0; j <= arrBMIAverage.Length - 1; j++)
            {
                if (arrBMIAverage[j] > 0)
                {
                    if (arrBMIAverage[j] < vMin)
                    {
                        vMin = arrBMIAverage[j];
                    }
                }
            }

            BMIMinLabel.Text = Math.Round(vMin, 1).ToString(); // display the result to one decimal place
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            BMISearchValidation(); // run the BMISearchValidation() method
        }

        void BMISearchValidation() // to check for reasonable BMI values
        {
            string BMIV = BMISearchTextBox.Text; // set the variable to whatever entered by the user
            double BMIValidDouble; // boolean variable to check data type

            bool vCheckDoubleType = double.TryParse(BMIV, out BMIValidDouble);

            if (String.IsNullOrEmpty(BMIV)) // check if the textBox is empty - no values entered and display a message
            {
                MessageBox.Show("Please enter a BMI value to search for");
            }

            else if (vCheckDoubleType == false) // check if the data entered is double - no symboles or letters allowed (except for ".") and display a message
            {
                MessageBox.Show("Please enter a numerical value");
            }

            else if (BMIValidDouble < 0) // check for negative values and display a message
            {
                MessageBox.Show("Please enter a valid BMI - no negative numbers!");
            }

            else
            {
                SearchXML(); // run the search if the values passes all the tests
            }
        }

        void SearchXML() // allows search for specific BMI values
        {
            bool found = false; // a boolean variable to check if the value is found or not

            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("measures.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes("measures/person")) // search the whole XML file
            {
                if (xNode.SelectSingleNode("BMI").InnerText == BMISearchTextBox.Text) // specifically look at the BMI nodes to check for the values
                {
                    found = true; // if the value in XML matches with the value entered by user, then set found to true
                    FoundLabel.ForeColor = System.Drawing.Color.Green; // change the font colour to green 
                    FoundLabel.Text = "Found"; // display found
                }
            }

            if (!found) // if it does not match with the value entered by user
            {
                FoundLabel.ForeColor = System.Drawing.Color.Red; // change the font colour to red
                FoundLabel.Text = "NOT Found"; // display not found
            }
        }
    }
}
