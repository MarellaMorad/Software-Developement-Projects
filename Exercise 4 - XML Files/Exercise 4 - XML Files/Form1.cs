using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text;

namespace Exercise_4___XML_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            XMLCheck();
        }

        void XMLCheck()
        {
            if (File.Exists("library.xml") == false)
            {
                NewXMLandSaveData();
            }

            else if (File.Exists("library.xml") == true)
            {
                SaveData();
            }

            void NewXMLandSaveData()
            {
                //creates the XML file called people.xml, using a new XmlTextWriter called xWriter
                XmlTextWriter xWriter = new XmlTextWriter("library.xml", Encoding.UTF8);

                xWriter.Formatting = Formatting.Indented; // format the xml to use indentation
                xWriter.WriteStartElement("library");
                xWriter.WriteStartElement("book");
                xWriter.WriteStartElement("name");
                xWriter.WriteString(NameTextBox.Text);
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("location");
                xWriter.WriteString(LocationTextBox.Text);
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("price");
                xWriter.WriteString(PriceTextBox.Text);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();

                xWriter.Close(); // to close access to the xml so it can be used by other applications.

                XmlDocument xDoc = new XmlDocument(); // to be able to load, edit, add...
                xDoc.Load("library.xml");

                XmlDeclaration xmldecl; // create a declaration which is the line underneeth
                xmldecl = xDoc.CreateXmlDeclaration("1.0", "UTF-8", null);

                //Insert the XML declaration into the XML file and save
                XmlElement root = xDoc.DocumentElement;
                xDoc.InsertBefore(xmldecl, root); // to insert it before the root element <library>
                xDoc.Save("library.xml");
            }

            void SaveData()
            {
                //load the XML document
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("library.xml");

                //create the new elements (under the root element)
                XmlNode book = xDoc.CreateElement("book"); //represents a single node/tag in the Xml file 
                XmlNode name = xDoc.CreateElement("name");
                XmlNode location = xDoc.CreateElement("location");
                XmlNode price = xDoc.CreateElement("price");

                // Get the value from the textbox and put into the text of the element, save the XML
                name.InnerText = NameTextBox.Text;
                book.AppendChild(name);
                location.InnerText = LocationTextBox.Text;
                book.AppendChild(location);
                price.InnerText = PriceTextBox.Text;
                book.AppendChild(price);
                xDoc.DocumentElement.AppendChild(book);
                xDoc.Save("library.xml");
            }


        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchXML();
        }

        void SearchXML()
        {
            PriceLabel.Text = "";
            LocationLabel.Text = "";
            bool found = false;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("library.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes("library/book"))
            {
                if (xNode.SelectSingleNode("name").InnerText == SearchTextBox.Text)
                {
                    PriceLabel.Text = xNode.SelectSingleNode("price").InnerText;
                    LocationLabel.Text = xNode.SelectSingleNode("location").InnerText;
                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("Book not found");
            }
        }

    }
}
