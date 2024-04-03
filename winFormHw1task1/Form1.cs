namespace winFormHw1task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var x = random.Next(0, 400);
            var y = random.Next(0, 400);
            YesButton.Location = new Point(x, y);
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We never doubted you , even for a second!(>◡<)−☆", "Yay!");
        }
    }
}
