namespace Assignement_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();


            if (saveFileDialog.ShowDialog() == DialogResult.OK) {

                string filePath = saveFileDialog.FileName;
                int userInputNumOfRand;

                if (int.TryParse(textBox2.Text, out userInputNumOfRand))

                {
                    Random random = new Random();
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        for (int i = 0; i < userInputNumOfRand; i++)
                        {
                            int randomNumber = random.Next(1, 101);
                            sw.WriteLine(randomNumber);
                        }
                    }
                    MessageBox.Show("File writing Complete!!");
                }
            
            }                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}