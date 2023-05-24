namespace Switch_Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean lightON = true;
        Boolean onLabel = true;
        private void switchLight() 
        {
            if (lightON)
            {
                pictureBox1.Visible= true;
                pictureBox2.Visible= false;
                label1.Visible= true;
                label2.Visible= false;
            } else
            {
                pictureBox1.Visible= false;
                pictureBox2.Visible= true;
                label1.Visible= false;
                label2.Visible= true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lightON = !lightON;
            switchLight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}