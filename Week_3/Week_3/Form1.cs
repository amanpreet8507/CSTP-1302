using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton3.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // result
        {
            
        }

        private void button2_Click(object sender, EventArgs e) //+
        {
            int operand1, operand2;
            operand1 = int.Parse(textBox1.Text);
            operand2 = int.Parse(textBox2.Text);
            int result = operand1 + operand2;
            MessageBox.Show(result.ToString());
            listBox1.Items.Add($"{ operand1} + {operand2} = {result}");

        }

        private void button3_Click(object sender, EventArgs e) //-
        {
            int operand1, operand2;
            operand1 = int.Parse(textBox1.Text);
            operand2 = int.Parse(textBox2.Text);
            int result = operand1 - operand2;
            MessageBox.Show(result.ToString());
            listBox1.Items.Add($"{ operand1} - {operand2} = {result}");

        }

        private void button4_Click(object sender, EventArgs e) // /
        {
            int operand1, operand2;
            operand1 = int.Parse(textBox1.Text);
            operand2 = int.Parse(textBox2.Text);
            int result = operand1 / operand2;
            MessageBox.Show(result.ToString());
            listBox1.Items.Add($"{ operand1} / {operand2} = {result}");
        }

        private void button5_Click(object sender, EventArgs e)// *
        {
            int operand1, operand2;
            operand1 = int.Parse(textBox1.Text);
            operand2 = int.Parse(textBox2.Text);
            int result = operand1 * operand2;
            MessageBox.Show(result.ToString());
            listBox1.Items.Add($"{ operand1} * {operand2} = {result}");

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // operand 1
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) // operand 2
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}
