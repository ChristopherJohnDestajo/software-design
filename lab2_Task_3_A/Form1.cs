namespace lab2_Task_3_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int RecursiveFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btn_Calculate_nth_Click(object sender, EventArgs e)
        {
            int number = int.Parse(FibonacciInput.Text);
            int result = RecursiveFibonacci(number);
            lblFibonacciResult.Text = $"Fibonacci={result}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
