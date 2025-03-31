namespace Task_5_A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] BubbleSortMethod(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {

                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
        private void btn_Sort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 3, 2, 4 };
            int[] sortedNumbers = BubbleSortMethod(numbers);
            listBoxResult.DataSource = sortedNumbers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
