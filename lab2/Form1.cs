namespace lab2
{
    public partial class txtInput : Form
    {
        public txtInput()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);
        }

        private void btn_Calculate_Factorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textinput.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial:{result}";
        }
        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void btn_Calculate_Sum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResults.Text = $"Sum:{result}";
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
