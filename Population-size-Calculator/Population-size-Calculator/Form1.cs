namespace Population_size_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double organisms;
            double averageDailyIncrease;
            double days;
            if (double.TryParse(textBox1.Text, out organisms) &&
                double.TryParse(textBox2.Text, out averageDailyIncrease) &&
                double.TryParse(textBox3.Text, out days))
            {
                int counter = 1;
                listBox1.Items.Add($"Day \t Approximate Population");
                double sum = organisms;
                while (counter <= days)
                {
                    listBox1.Items.Add($"{counter} \t {sum}");
                    sum = sum * (1 + averageDailyIncrease / 100);
                    counter++;
                }




            }
            else
            {
                MessageBox.Show("There is an error!!");
            }

        }
    }
}