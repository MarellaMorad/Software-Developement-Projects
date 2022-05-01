using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text;

namespace Multiple_forms_practice
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		int vAge;

		private void button1_Click(object sender, EventArgs e)
		{
			vAge = int.Parse(textBox1.Text);
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

			for (int j = 0; j <= arrAgeAverage.Length - 1; j++)
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
