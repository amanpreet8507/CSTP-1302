using System;
using System.Reflection.Metadata;

namespace Assignment_1_Part_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Create another application that uses an OpenFileDialog control to let the
        //user select the file that was created by the application that you wrote for Problem 13.
        //This app should read the numbers from the file, display the numbers in a ListBox control, then display the follwing data:
        // the total of the numbers 
        // the number of random numbers read from the file




        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;

                if (!string.IsNullOrEmpty(selectedFile))
                {

                    string[] lines = File.ReadAllLines(selectedFile);


                    List<int> nums = new List<int>();

                    foreach (string line in lines)
                    {
                        if (int.TryParse(line, out int number))
                        {
                            nums.Add(number);
                        }
                    }

                    listBox1.Items.Clear();
                    foreach (int number in nums)
                    {
                        listBox1.Items.Add(number);
                    }

                    int total = nums.Sum();

                    listBox1.Items.Add($"Total of Random Numbers: {total}");
                    listBox1.Items.Add($"Total of Random Numbers: {nums.Count}");
                }
                else
                {

                    MessageBox.Show("Invalid file path");
                }
            }
        }
    }
}
//using (StreamWriter sw = new StreamWriter(filePath))
//{
//    for (int i = 0; i < userInputNumOfRand; i++)
//    {
//        int randomNumber = random.Next(1, 101);
//        sw.WriteLine(randomNumber);
//    }
//}