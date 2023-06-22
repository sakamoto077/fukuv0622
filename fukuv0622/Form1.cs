using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace fukuv0622
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] data = new int[10];
            label1.Text = "";
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                data[i] = rand.Next(101);
                label1.Text += $"{data[i]},";
                sum += data[i];
            }

            MessageBox.Show($"{sum / 10}");
        }
    }
}