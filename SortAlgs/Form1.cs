using SortAlgs.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgs
{
    public partial class Form1 : Form
    {
        private int[] numbers;
        Testing testing;
        Stopwatch sw;

        public Form1()
        {
            InitializeComponent();
            testing = new Testing();
            sw = new Stopwatch();
        }

        /// <summary>
        /// Gibt die eingegebenen Zahlen im oberen Eingabefeld als Array zurück
        /// </summary>
        /// <returns></returns>
        private int[] GetArrayFromForm()
        {
            string[] inputArray = textBoxInput.Text.Split(' ');
            int[] numberArray = new int[inputArray.Length];
            for (int i = 0; i < numberArray.Length; i++) 
            {
                int.TryParse(inputArray[i], out numberArray[i]);
            }
            return numberArray;
        }

        /// <summary>
        /// Löscht den Text aus den beiden oberen Textboxen
        /// </summary>
        public void ResetTextBoxes()
        {
            textBoxInput.Text = string.Empty;
            textBoxOutput.Text = string.Empty;
        }

        /// <summary>
        /// Generiert zufällige Nummern, entweder selbstständig oder falls es eine Vorgegebene
        /// Anzahl gibt, dann genau diese Anzahl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandNumbers_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
            int count = 500000;
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            int randomNumbers = !string.IsNullOrEmpty(textBoxCount.Text) ?
                Convert.ToInt32(textBoxCount.Text) : random.Next(100000, count);

            sw.Start();
            numbers = new int[randomNumbers];
            for (int i = 0; i < randomNumbers; i++)
            {
                numbers[i] = random.Next(100000, int.MaxValue);
                stringBuilder.Append(numbers[i].ToString() + " ");
            }
            sw.Stop();
            textBoxInput.Text = stringBuilder.ToString().Substring(0, stringBuilder.ToString().Length - 1);
            textBoxLog.Text += string.Format("Generierte Nummern ({0}) - Zeit: {1}\r\n", randomNumbers, sw.Elapsed);
            Console.WriteLine("Generierte Nummern ({0}) - Zeit: {1}", randomNumbers, sw.Elapsed);
            sw.Reset();
        }

        /// <summary>
        /// Sortiert die eingebenen Zahlen mithilfe des Bubble Sorts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBubble_Click(object sender, EventArgs e)
        {
            numbers = GetArrayFromForm();

            sw.Start();
            BubbleSort bubbleSort = new BubbleSort();
            StringBuilder stringBuilder = new StringBuilder();
            int[] array = bubbleSort.Run(numbers);
            sw.Stop();

            foreach (var element in array)
            {
                stringBuilder.Append(element.ToString() + " ");
            }
            textBoxOutput.Text = stringBuilder.ToString();

            if (checkBoxTesting.Checked)
            {
                labelValid.Text = "Valid: " + testing.Run(array).ToString();
            }
            textBoxLog.Text += "BubbleSort Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("BubbleSort Zeit: " + sw.Elapsed);
            sw.Reset();
        }

        /// <summary>
        /// Testet ob der Bubble Sort Mechanismus funktioniert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBubbleTest_Click(object sender, EventArgs e)
        {
            sw.Start();
            bool valid = true;
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                numbers = new int[3000];
                for (int x = 0; x < 3000; x++)
                {
                    numbers[x] = random.Next(100, 100000);
                }
                BubbleSort bubbleSort = new BubbleSort();
                int[] array = bubbleSort.Run(numbers);
                valid = testing.Run(array);
            }
            
            sw.Stop();
            textBoxLog.Text += "BubbleSort Testing Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("BubbleSort Testing - Zeit: " + sw.Elapsed);
            Console.WriteLine("Valid: " + valid);
            sw.Reset();
        }

        /// <summary>
        /// Sortiert die eingebenen Zahlen mithilfe des Insertion Sorts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInsertion_Click(object sender, EventArgs e)
        {
            numbers = GetArrayFromForm();
            sw.Start();
            InsertionSort insertionSort = new InsertionSort();
            StringBuilder stringBuilder = new StringBuilder();
            int[] array = insertionSort.Run(numbers);
            sw.Stop();

            foreach (var element in array)
            {
                stringBuilder.Append(element.ToString() + " ");
            }
            textBoxOutput.Text = stringBuilder.ToString();

            if (checkBoxTesting.Checked)
            {
                labelValid.Text = "Valid: " + testing.Run(array).ToString();
            }
            textBoxLog.Text += "Insertion Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("Insertion Zeit: " + sw.Elapsed);
            sw.Reset();
        }

        /// <summary>
        /// Testet ob der Insertion Sort Mechanismus funktioniert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInsertionTest_Click(object sender, EventArgs e)
        {
            sw.Start();
            bool valid = true;
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                numbers = new int[3000];
                for (int x = 0; x < 3000; x++)
                {
                    numbers[x] = random.Next(100, 100000);
                }
                InsertionSort insertionSort = new InsertionSort();
                int[] array = insertionSort.Run(numbers);
                valid = testing.Run(array);
            }

            sw.Stop();
            textBoxLog.Text += "Insertion Testing Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("Insertion Testing - Zeit: " + sw.Elapsed);
            Console.WriteLine("Valid: " + valid);
            sw.Reset();
        }

        /// <summary>
        /// Sortiert die eingebenen Zahlen mithilfe des Selection Sorts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelection_Click(object sender, EventArgs e)
        {
            numbers = GetArrayFromForm();
            sw.Start();
            SelectionSort selectionSort = new SelectionSort();
            StringBuilder stringBuilder = new StringBuilder();
            int[] array = selectionSort.Run(numbers);
            sw.Stop();

            foreach (var element in array)
            {
                stringBuilder.Append(element.ToString() + " ");
            }
            textBoxOutput.Text = stringBuilder.ToString();

            if (checkBoxTesting.Checked)
            {
                labelValid.Text = "Valid: " + testing.Run(array).ToString();
            }
            textBoxLog.Text += "Selection Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("Selection Zeit: " + sw.Elapsed);
            sw.Reset();
        }

        /// <summary>
        /// Testet ob der Selection Sort Mechanismus funktioniert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectionTest_Click(object sender, EventArgs e)
        {
            sw.Start();
            bool valid = true;
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                numbers = new int[3000];
                for (int x = 0; x < 3000; x++)
                {
                    numbers[x] = random.Next(100, 100000);
                }
                SelectionSort selectionSort = new SelectionSort();
                int[] array = selectionSort.Run(numbers);
                valid = testing.Run(array);
            }

            sw.Stop();
            textBoxLog.Text += "Selection Testing Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("Selection Testing - Zeit: " + sw.Elapsed);
            Console.WriteLine("Valid: " + valid);
            sw.Reset();
        }

        /// <summary>
        /// Sortiert die eingebenen Zahlen mithilfe des Quick Sorts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonQuick_Click(object sender, EventArgs e)
        {
            numbers = GetArrayFromForm();
            sw.Reset();
            sw.Start();
            QuickSort quickSort = new QuickSort();
            StringBuilder stringBuilder = new StringBuilder();
            int[] array = quickSort.Run(numbers);
            sw.Stop();

            foreach (var element in array)
            {
                stringBuilder.Append(element.ToString() + " ");
            }
            textBoxOutput.Text = stringBuilder.ToString();

            if (checkBoxTesting.Checked)
            {
                labelValid.Text = "Valid: " + testing.Run(array).ToString();
            }
            textBoxLog.Text += "QuickSort Zeit: " + sw.Elapsed + "\r\r\n";
            Console.WriteLine("QuickSort Zeit: " + sw.Elapsed);
            sw.Reset();
        }

        /// <summary>
        /// Testet ob der Quick Sort Mechanismus funktioniert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonQuickTest_Click(object sender, EventArgs e)
        {
            sw.Start();
            bool valid = true;
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                numbers = new int[3000];
                for (int x = 0; x < 3000; x++)
                {
                    numbers[x] = random.Next(100, 100000);
                }
                QuickSort quickSort = new QuickSort();
                int[] array = quickSort.Run(numbers);
                valid = testing.Run(array);
            }

            sw.Stop();
            textBoxLog.Text += "QuickSort Testing Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("QuickSort Testing - Zeit: " + sw.Elapsed);
            Console.WriteLine("Valid: " + valid);
            sw.Reset();
        }

        /// <summary>
        /// Testet alle Mechanismen mit den selben Zahlen und schaut welcher am schnellsten ist (Quick)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTestAll_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            numbers = new int[100000];
            for (int x = 0; x < 100000; x++)
            {
                numbers[x] = random.Next(1, 100);
            }

            sw.Start();

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Run(numbers);

            sw.Stop();
            textBoxLog.Text += "BubbleSort Testing Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("BubbleSort Testing - Zeit: " + sw.Elapsed);
            sw.Reset();
            sw.Start();

            InsertionSort insertionSort = new InsertionSort();
            insertionSort.Run(numbers);

            sw.Stop();
            textBoxLog.Text += "InsertionSort Testing Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("InsertionSort Testing - Zeit: " + sw.Elapsed);
            sw.Reset();
            sw.Start();

            SelectionSort selectionSort = new SelectionSort();
            selectionSort.Run(numbers);

            sw.Stop();
            textBoxLog.Text += "SelectionSort Testing Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("SelectionSort Testing - Zeit: " + sw.Elapsed);
            sw.Reset();
            sw.Start();

            QuickSort quickSort = new QuickSort();
            quickSort.Run(numbers);

            sw.Stop();
            textBoxLog.Text += "QuickSort Testing Zeit: " + sw.Elapsed + "\r\n";
            Console.WriteLine("QuickSort Testing - Zeit: " + sw.Elapsed);
            sw.Reset();
        }
    }
}
