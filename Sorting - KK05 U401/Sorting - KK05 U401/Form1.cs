using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting___KK05_U401
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void SelectionBtn_Click(object sender, EventArgs e)
		{
			int[] arrNumbers = CreateRandomArray();
			SelectionListBox.Items.Add("Unsorted Array");
			DisplaySelectionArray(arrNumbers);
			SelectionSort(arrNumbers);
			SelectionListBox.Items.Add("Sorted Array");
			DisplaySelectionArray(arrNumbers);
		}
		
		private int[] CreateRandomArray()
		{
			int vMin = 0; //minimum value that can be generated
			int vMax = int.Parse(IndexTextBox.Text); //maximum number of indexes set by the user
			int[] arrNumbers = new int[vMax];// create the array and set its indexes to vMax

			Random randNum = new Random(); //generates a random number array

			for (int i = 0; i < arrNumbers.Length; i++)
			{
				arrNumbers[i] = randNum.Next(vMin, vMax); //assign the number of random values
			}

			return arrNumbers; // returns the value to Controller
		}

		void DisplaySelectionArray(int[] array)
		{
			for (int j = 0; j <= array.Length - 1; j++)
			{
				SelectionListBox.Items.Add(array[j]);
			}
		}

		void SelectionSort(int [] array)
		{
			int pos_min = 0; //stores the index of the currently found lowest number
			int temp = 0; // stores the value (not the index) to be swapped

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

		private void QuickBtn_Click(object sender, EventArgs e)
		{
			int[] arrNumbers = CreateRandomArray();
			QuickListBox.Items.Add("Unsorted Array");
			DisplayQuickArray(arrNumbers);
			QuickSort(arrNumbers, 0, arrNumbers.Length - 1);
			QuickListBox.Items.Add("Sorted Array");
			DisplayQuickArray(arrNumbers);
		}

		void DisplayQuickArray(int[] array)
		{
			for (int j = 0; j <= array.Length - 1; j++)
			{
				QuickListBox.Items.Add(array[j]);
			}
		}

		static void QuickSort(int[] array, int start, int end) //Method - Quicksort Algorithm
		{
			int pivot = array[end]; //if wanting to use the middle index value as pivot, change to array[(start + end) / 2]
			int i = start;
			int j = end;
			int temp;

			while (i <= j)
			{
				while (array[i] < pivot)
				{
					i++;
				}

				while (array[j] > pivot)
				{
					j--;
				}

				if (i <= j)
				{
					temp = array[i];
					array[i] = array[j];
					array[j] = temp;
					i++;
					j--;
				}
			}

			if (start < j)
			{
				QuickSort(array, start, j);
			}

			if (i < end)
			{
				QuickSort(array, i, end);
			}
		}
	}
}
