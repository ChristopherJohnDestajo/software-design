namespace lab2_Task_3_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursivePower(int x, int n)
        {
            if (n == 0) return 1;
            return x * RecursivePower(x, n - 1);
        }

        private void btn_Calculate_Exponent_Click(object sender, EventArgs e)
        {
            int baseNumber = int.Parse(txtBaseInput.Text);
            int exponent = int.Parse(txtExponentInput.Text);
            int result = RecursivePower(baseNumber, exponent);
            lblPowerResult.Text = $"Answer:{result}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
