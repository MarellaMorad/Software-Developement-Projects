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
	}
}
