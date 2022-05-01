using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text;

namespace KK04___XML_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XMLCheck();
            Averages();
        }

        void XMLCheck()
        {
            if (File.Exists("people.xml") == false)
            {
                NewXMLandSaveData();
                Console.WriteLine("file not found");
            }

            else if (File.Exists("people.xml") == true)
            {
                SaveData();
                Averages();
            }
        }

        void NewXMLandSaveData()
        {
            //creates the XML file called people.xml, using a new XmlTextWriter called xWriter
            XmlTextWriter xWriter = new XmlTextWriter("people.xml", Encoding.UTF8);

            xWriter.Formatting = Formatting.Indented; // format the xml to use indentation
            xWriter.WriteStartElement("people");
            xWriter.WriteStartElement("person");
            xWriter.WriteStartElement("name");
            xWriter.WriteString(NameTextBox.Text);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("age");
            xWriter.WriteString(AgeTextBox.Text);
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();

            xWriter.Close(); // to close access to the xml so it can be used by other applications.

            XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
            xDoc.Load("people.xml");

            XmlDeclaration xmldecl; // create a declaration which is the line underneeth
            xmldecl = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

            //Insert the XML declaration into the XML file and save
            XmlElement root = xDoc.DocumentElement;
            xDoc.InsertBefore(xmldecl, root); // to insert it before the root element <people>
            xDoc.Save("people.xml");
        }

        void SaveData()
        {
            //load the XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("people.xml");

            //create the new elements (under the root element)
            XmlNode person = xDoc.CreateElement("person"); //represents a single node/tag in the Xml file 
            XmlNode name = xDoc.CreateElement("name");
            XmlNode age = xDoc.CreateElement("age");

            // Get the value from the textbox and put into the text of the element, save the XML
            name.InnerText = NameTextBox.Text;
            person.AppendChild(name);
            age.InnerText = AgeTextBox.Text;
            person.AppendChild(age);
            xDoc.DocumentElement.AppendChild(person);
            xDoc.Save("people.xml");
        }

        void Averages()
        {
            //create arrays to store XML data, and variables
            int[] arrAgeAverage = new int[10];
            int vTotal = 0;
            int vCount = 0;
            int vAverage = 0;
            int i = 0;

            //load XML document
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("people.xml");

            //Loop through each node/tag, select data from element into array, Increase i
            foreach (XmlNode xNode in xDoc.SelectNodes("people/person"))
            {
                arrAgeAverage[i] = int.Parse(xNode.SelectSingleNode("age").InnerText);
                i++;
            }

            //Listbox to check if the values are entering the array
            listBox1.Items.Clear();

            for(int j = 0; j <= arrAgeAverage.Length - 1; j++)
            {
                listBox1.Items.Add(arrAgeAverage[j]);
            }

            //loop to calculate the averages and display in a label
            for (int k = 0; k <= arrAgeAverage.Length - 1; k++)
            {
                if (arrAgeAverage[k] > 0)
                {
                    vTotal = vTotal + arrAgeAverage[k];
                    vCount = vCount + 1;
                }

                vAverage = vTotal / vCount;
                AgeAveLabel.Text = vAverage.ToString();
            }
        }
    }
}
