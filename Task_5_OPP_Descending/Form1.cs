namespace Task_5_OPP_Descending
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class DescendingSorter
        {
            public int[] SortDescending(int[] numbers)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = 0; j < numbers.Length - i - 1; j++)
                    {
                        if (numbers[j] < numbers[j + 1])
                        {
                            (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                        }
                    }
                }
                return numbers;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 3, 2, 4 };
            var sorter = new DescendingSorter();
            listBoxResult.DataSource = sorter.SortDescending(numbers);
        }
    }
}
