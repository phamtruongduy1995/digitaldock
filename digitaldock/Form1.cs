namespace digitaldock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
